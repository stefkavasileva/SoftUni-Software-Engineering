let expect = require('chai').expect;

let makeList = require('../02.AddLeftRightClearInList');

describe("Unit tests of makeList function …", function() {
    let myList = {};
    beforeEach(function () {
        myList = makeList();
    });
    it("Has initial value", function () {
        expect(myList.hasOwnProperty('addLeft')).to.be.equal(true);
        expect(myList.hasOwnProperty('addRight')).to.be.equal(true);
        expect(myList.hasOwnProperty('clear')).to.be.equal(true);
        expect(myList.hasOwnProperty('toString')).to.be.equal(true);
    });

    it("Test addLeft function", function () {
        myList.addLeft(3);
        myList.addLeft('string');
        myList.addLeft({});

        expect(myList.toString()).to.be.equal('[object Object], string, 3');
    });

    it("Test addRight function", function () {
        myList.addRight(3);
        myList.addRight('string');
        myList.addRight({});

        expect(myList.toString()).to.be.equal('3, string, [object Object]');
    });

    it("Test clear function", function () {
        myList.addRight(3);
        myList.addRight('string');
        myList.addRight({});
        myList.clear();
        expect(myList.toString()).to.be.equal('');
    });
});