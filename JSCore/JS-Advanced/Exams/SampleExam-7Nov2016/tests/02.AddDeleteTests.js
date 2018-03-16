let expect = require('chai').expect;

let list = require('../02.AddDeleteInList');

//62/100
describe("list function test", function () {
    it("Should has add prop", function () {
        expect(list.hasOwnProperty('add')).to.be.equal(true);
    });

    it("Should has delete prop", function () {
        expect(list.hasOwnProperty('delete')).to.be.equal(true);
    });

    it("Should has toString prop", function () {
        expect(list.hasOwnProperty('toString')).to.be.equal(true);
    });

    it("Test toString function with empty list", function () {
        expect(list.toString()).to.be.equal('');
    });

    it("Test add function", function () {
        list.add(3);
        list.add('string');
        list.add({});
        expect(list.toString()).to.be.equal('3, string, [object Object]');
    });

    it("Test toString function", function () {
        expect(list.toString()).to.be.equal('3, string, [object Object]');
    });


    it("Test delete function with valid index", function () {
        list.add(1);
        list.add(3);
        list.add(2);

        expect(list.delete(0)).to.be.equal(3);
    });

    it("Test delete function with invalid index < 0", function () {
        expect(list.delete(-1)).to.be.undefined;
    });

    it("Test delete function with invalid index > length", function () {
        expect(list.delete(5000)).to.be.undefined;
    });

    it("Test delete function with invalid type of index", function () {
        expect(list.delete('invalidIndex')).to.be.undefined;
    });

    it("Test delete function with invalid type of index", function () {
        expect(list.delete({})).to.be.undefined;
    });

});

