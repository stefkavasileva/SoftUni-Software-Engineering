let expect = require('chai').expect;

const isSymmetric  = require('../05.0CheckForSymmetry');

describe('Test isSymmetric function', function () {
    it('Should return true', function () {
        expect(isSymmetric([-1,2,-1])).to.be.equal(true);
    });

    it('Should return true', function () {
        expect(isSymmetric(['1','2','1'])).to.be.equal(true);
    });

    it('Should return true', function () {
        expect(isSymmetric([1])).to.be.equal(true);
    });

    it('Should return false', function () {
        expect(isSymmetric([1,2])).to.be.equal(false);
    });

    it('Should return true', function () {
        expect(isSymmetric([])).to.be.equal(true);
    });

    it('Should return false', function () {
        expect(isSymmetric('invalid date')).to.be.equal(false);
    });

    it('Should return true', function () {
        expect(isSymmetric([1,'str',{x:5},new Date(),{x:5},'str',1])).to.be.equal(true);
    });

});
