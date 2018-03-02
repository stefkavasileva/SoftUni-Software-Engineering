let expect = require('chai').expect;

const sum  = require('../04.SumOfNumbers');

describe('Test sum function', function () {
    it('Should return 3', function () {
        expect(sum([1,2])).to.be.equal(3);
    });

    it('Should return 0 ', function () {
        expect(sum([])).to.be.equal(0);
    });

    it('Should return NaN', function () {
        expect(sum('invalid date')).to.be.NaN;
    });

    it('Should return 7', function () {
        expect(sum([1.5,4,3,-1.5])).to.be.equal(7);
    });

    it('Should return [1]', function () {
        expect(sum([1])).to.be.equal(1);
    });
});

