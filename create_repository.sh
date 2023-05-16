#!/bin/bash

if [ "$#" -ne 3 ]; then
    echo "Usage ./create_repository.sh <organization> <name> <access_token>"
    exit 1
fi

ORGANIZATION=$1
NAME=$2
ACCESS_TOKEN=$3

API_URL="https://api.github.com/orgs/$ORGANIZATION/repos"

# Create the repository and store the response
RESPONSE=$(curl -X POST -sH "Authorization: bearer $ACCESS_TOKEN" -d "{\"name\": \"$NAME\"}" $API_URL)

# Check if response is empty and return 1 if so, echoing a message that says that the call failed
if [ -z "$RESPONSE" ]; then
    echo "Call to $API_URL failed"
    exit 1
fi

# Extract the repository name from the response
REPOSITORY_NAME=$(echo $RESPONSE | jq -r '.name')

# Print the repository name
echo $REPOSITORY_NAME