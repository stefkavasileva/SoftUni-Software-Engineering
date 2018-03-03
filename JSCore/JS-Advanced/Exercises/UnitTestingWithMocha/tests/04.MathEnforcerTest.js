let expect = require('chai').expect;

const mathEnforcer  = require('../04.MathEnforcer');

describe('Test functions of an object', function () {
    describe('Tests with valid data', function () {
        describe('addFive tests',function () {
            it('Should add 5 to valid number param', function () {
                expect(mathEnforcer.addFive(10)).to.equal(15);
            });

            it('Should add 5 to valid number param', function () {
                expect(mathEnforcer.addFive(-10)).to.equal(-5);
            });

            it('Should add 5 to valid number param', function () {
                expect(mathEnforcer.addFive(1.5)).to.equal(6.5);
            });

            it('Should subtract 10 from number', function () {
                expect(mathEnforcer.subtractTen(20)).to.equal(10);
            });

            it('Should subtract 10 from number', function () {
                expect(mathEnforcer.subtractTen(-20)).to.equal(-30);
            });

            it('Should subtract 10 from number', function () {
                expect(mathEnforcer.subtractTen(10.1)).to.equal(0.09999999999999964);
            });

            it('Should return sum of two valid numbers', function () {
                expect(mathEnforcer.sum(20,20)).to.equal(40);
            });

            it('Should return sum of two valid numbers', function () {
                expect(mathEnforcer.sum(1.5,1.5)).to.equal(3);
            });

            it('Should return sum of two valid numbers', function () {
                expect(mathEnforcer.sum(-1.5,1.5)).to.equal(0);
            });
        });
    });

    describe('Tests with invalid data', function () {
        describe('addFive tests',function () {
            it('Should return undefined with invalid param', function () {
                expect(mathEnforcer.addFive('10')).to.be.undefined;
            });

            it('Should return undefined with invalid param', function () {
                expect(mathEnforcer.addFive({})).to.be.undefined;
            });

            it('Should return undefined with invalid param', function () {
                expect(mathEnforcer.subtractTen([])).to.be.undefined;
            });

            it('Should return undefined with invalid param', function () {
                expect(mathEnforcer.subtractTen('10')).to.be.undefined;
            });

            it('Should return undefined with invalid params', function () {
                expect(mathEnforcer.sum('10',2)).to.be.undefined;
            });

            it('Should return undefined with invalid params', function () {
                expect(mathEnforcer.sum(2,'10')).to.be.undefined;
            });

            it('Should return undefined with invalid params', function () {
                expect(mathEnforcer.sum('10','10')).to.be.undefined;
            });

            it('Should return undefined with invalid params', function () {
                expect(mathEnforcer.sum({},{})).to.be.undefined;
            });
        });
    });
});
