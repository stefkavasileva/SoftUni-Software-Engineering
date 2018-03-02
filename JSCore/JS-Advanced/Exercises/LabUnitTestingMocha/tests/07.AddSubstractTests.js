let expect = require('chai').expect;

const createCalculator  = require('../07.AddSubtract');

describe('Test createCalculator function', function () {
    it('Should return 5', function () {
        let testObj = createCalculator();
        testObj.add(5);
        expect(testObj.get()).to.be.equal(5);
    });

    it('Should return 0', function () {
        let testObj = createCalculator();
        testObj.add(5);
        testObj.subtract(5);
        expect(testObj.get()).to.be.equal(0);
    });

    it('Should return 0', function () {
        let testObj = createCalculator();
        testObj.add('Invalid data');
        expect(testObj.get()).to.be.NaN;
    });

    it('Should return 0', function () {
        let testObj = createCalculator();
        testObj.add(5);
        testObj.add('5');
        expect(testObj.get()).to.be.equal(10);
    });
})
