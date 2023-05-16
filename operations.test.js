const assert = require('assert');
const operations = require('./operations.js');
const { describe } = require('node:test');

describe('operations', function() {
    describe('sum', () => {
        it('should sum 2 and 2 and the result must be 4', () => {
            assert.strictEqual(operations.sum(2, 2), 4);
        });
    });

    describe('sub', () => {
        it('should sub 2 and 2 and the result must be 0', () => {
            assert.strictEqual(operations.sub(2, 2), 0);
        });
    });

    describe('mul', () => {
        it('should mul 2 and 2 and the result must be 4', () => {
            assert.strictEqual(operations.mul(2, 2), 4);
        });
    });

    describe('div', () => {
        it('should div 2 and 2 and the result must be 1', () => {
            assert.strictEqual(operations.div(2, 2), 1);
        });

        it('should div 2 and 0 and the result must be throw an error', () => {
            assert.throws(() => {
                operations.div(2, 0);
            });
        });
    });
});
