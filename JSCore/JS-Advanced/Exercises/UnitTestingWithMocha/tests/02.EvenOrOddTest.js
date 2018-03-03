let expect = require('chai').expect;

const isOddOrEven  = require('../02.EvenOrOdd');

describe('Test event or odd is length of a string', function () {
    describe('Tests with valid data', function () {
        it('Should return odd', function () {
            expect(isOddOrEven("odd str")).to.equal("odd");
        });

        it('Should return even', function () {
            expect(isOddOrEven("even str")).to.equal("even");
        });
    });

    describe('Tests with invalid data', function () {
        it('Should return undefined', function () {
            expect(isOddOrEven({})).to.be.undefined
        });

        it('Should return undefined', function () {
            expect(isOddOrEven([])).to.be.undefined
        });
    });
});
