const operations = require('./operations.js');

const [num1, num2, operation] = process.argv.slice(2);

if (!num1 || !num2 || !operation) {
    console.log('Invalid parameters');
    process.exit(1);
}

const number1 = parseFloat(num1);
const number2 = parseFloat(num2);

let result;

switch (operation) {
    case 'sum':
        result = operations.sum(number1, number2);
        break;
    case 'sub':
        result = operations.sub(number1, number2);
        break;
    case 'mul':
        result = operations.mul(number1, number2);
        break;
    case 'div':
        result = operations.div(number1, number2);
        break;
    default:
        console.log('Invalid operation');
        process.exit(1);
}

console.log(result);