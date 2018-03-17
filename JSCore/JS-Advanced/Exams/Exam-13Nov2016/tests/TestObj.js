let expect = require('chai').expect;

let createList = require('../02.AddSwapShiftLeftRightInList');

//78/100
describe('Test createList class', function () {
    it('Has initial param', function () {
        let list = new createList();
        expect(list.hasOwnProperty('add')).to.be.equal(true);
        expect(list.hasOwnProperty('shiftLeft')).to.be.equal(true);
        expect(list.hasOwnProperty('shiftRight')).to.be.equal(true);
        expect(list.hasOwnProperty('swap')).to.be.equal(true);
        expect(list.hasOwnProperty('toString')).to.be.equal(true);
    });

    it('Test add function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        expect(list.toString()).to.be.equal('2, test, [object Object], 3');
    });


    it('Test shiftLeft function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.shiftLeft();
        expect(list.toString()).to.be.equal('test, [object Object], 3, 2');
    });


    it('Test shiftRight function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.shiftRight();
        expect(list.toString()).to.be.equal('3, 2, test, [object Object]');
    });

    it('Test swap with valid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1)
        expect( list.swap(0,1)).to.be.equal(true);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap('str',1)).to.be.equal(false);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap('str',{})).to.be.equal(false);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap(1,{})).to.be.equal(false);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap(-1,2)).to.be.equal(false);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap(1,50)).to.be.equal(false);
    });


    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap(-1,-50)).to.be.equal(false);
    });

    it('Test swap with invalid number function', function () {
        let list = new createList();
        list.add(2);
        list.add('test');
        list.add({});
        list.add(3);
        list.swap(0,1);
        expect(list.swap(1,1)).to.be.equal(false);
    });

    it('Test toString with function', function () {
        let list = new createList();
        expect(list.toString()).to.be.equal('');
    });

    it('Test toString with function', function () {
        let list = new createList();
        list.add(2);
        list.add([]);
        expect(list.toString()).to.be.equal('2, ');
    });
});