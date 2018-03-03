let expect = require('chai').expect;

const lookupChar  = require('../03.CharLookup');

describe('Test lookupChar function', function () {
    describe('Tests with valid data', function () {
        it('Should return i with valid params', function () {
            expect(lookupChar("valid",3)).to.equal("i");
        });

        it('Should return i with valid params', function () {
            expect(lookupChar("valid",0)).to.equal("v");
        });

        it('Should return Incorrect index with empty string', function () {
            expect(lookupChar("",0)).to.equal("Incorrect index");
        });
    });

    describe('Tests with invalid data', function () {
        it('Should return undefined if first param isn\'t a string value', function () {
            expect(lookupChar({},2)).to.be.undefined
        });

        it('Should return undefined is second param is not a number', function () {
            expect(lookupChar('some string','2')).to.be.undefined
        });

        it('Should return Incorrect index if index is bigger then the string length', function () {
            expect(lookupChar('text',15)).to.equal('Incorrect index');
        });

        it('Should return Incorrect index if index is bigger then the string length', function () {
            expect(lookupChar('text',4)).to.equal('Incorrect index');
        });

        it('Should return Incorrect index if index is negative number', function () {
            expect(lookupChar('text',-1)).to.equal('Incorrect index');
        });

        it('Should return undefined if index is floating point number', function () {
            expect(lookupChar('text',2.2)).to.be.undefined;
        });
    });
});
