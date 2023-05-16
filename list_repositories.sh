#!/bin/bash

if [ "$#" -ne 2 ]; then
    echo "Usage: ./list_repositories.sh <organization> <access_token>"
    exit 1
fi

ORGANIZATION=$1
ACCESS_TOKEN=$2

PAGE=1
PER_PAGE=2

REPOSITORIES=()

while : ; do

    echo "Page $PAGE"
    API_URL="https://api.github.com/orgs/$ORGANIZATION/repos?page=$PAGE&per_page=$PER_PAGE"
    RESPONSE=$(curl -sH "Authorization: bearer $ACCESS_TOKEN" $API_URL)

    # Check if response is empty and return 1 if so, echoing a message that says that the call failed
    if [ -z "$RESPONSE" ]; then
        echo "Call to $API_URL failed"
        exit 1
    fi

    # Extract the repository names from the response and append them to the array
    REPOSITORIES+=($(echo $RESPONSE | jq -r '.[].name'))

    # Break the loop if the number of responses is slower than the per_page parameter
    if [ $(echo $RESPONSE | jq -r '. | length') -lt $PER_PAGE ]; then
        break
    fi

    # Increment the page number
    PAGE=$((PAGE+1))
done

# Print the array of repository names
for repo in "${REPOSITORIES[@]}"; do
    echo $repo
done
