//92/100

let expect = require('chai').expect;
let jsdom = require('jsdom-global')();
let $ = require('jquery');

document.body.innerHTML = `<div id="wrapper">
        <input type="text" id="name">
        <input type="text" id="income">
    </div>`;

let sharedObject = require('../05.SharedObject');

describe("sharedObject", function () {
    before(()=>global.$ = $);
    describe("Name and income should be null by default", function () {
        it("should return null for initial state of name", function () {
            expect(sharedObject.name).to.be.null;
        });

        it("should return null for initial state of income", function () {
            expect(sharedObject.income).to.be.null;
        });
    });

    describe("Test changeName and changeIncome in case an empty string is passed - no changes should be made", function () {
        it("Function should return undefined and no change should be made", function () {
            expect(sharedObject.changeName('')).to.be.undefined;
            expect(sharedObject.name).to.be.null;
            expect($('#name').val()).to.equal('');
        });

        it("Should change name prop and textbox value", function () {
            let testObj = sharedObject;
            testObj.changeName('Stefan');
            expect(testObj.name).to.equal('Stefan');
            expect($('#name').val()).to.equal('Stefan');
        });

        it("Function should return undefined and no change should be made", function () {
            expect(sharedObject.changeIncome('')).to.be.undefined;
            expect(sharedObject.changeIncome(-1)).to.be.undefined;
            expect(sharedObject.changeIncome(-1.3)).to.be.undefined;
            expect(sharedObject.income).to.be.null;
            expect($('#income').val()).to.equal('');
        });

        it("Should change income prop and textbox value", function () {
            let testObj = sharedObject;

            testObj.changeIncome(40);
            expect(testObj.income).to.be.equal(40);
            expect($('#income').val()).to.equal('40');
        });
    });

    describe("Test updateName and updateIncome", function () {
        it("In case the name textbox's value is an empty string - no changes should be made", function () {
            $('#name').val('');
            sharedObject.name = 'Not changed value';
            expect(sharedObject.updateName()).to.be.undefined;
            expect(sharedObject.name).to.equal('Not changed value');
        });

        it("In case the name textbox's value is not empty string update name value", function () {
            $('#name').val('Stephan');
            sharedObject.updateName();
            expect(sharedObject.name).to.equal('Stephan');
        });

        it("In case the income textbox's value is not integer value - no changes should be made", function () {
            $('#income').val('');
            sharedObject.income = 10;

            expect(sharedObject.updateIncome()).to.be.undefined;
            expect(sharedObject.income).to.be.equal(10);

            $('#income').val(-1);
            expect(sharedObject.updateIncome()).to.be.undefined;
            expect(sharedObject.income).to.be.equal(10);

            $('#income').val({});
            expect(sharedObject.updateIncome()).to.be.undefined;
            expect(sharedObject.income).to.be.equal(10);


            $('#income').val(2.1);
            expect(sharedObject.updateIncome()).to.be.undefined;
            expect(sharedObject.income).to.be.equal(10);

        });

        it("In case the income textbox's value is positive integer num, income prop should be updated", function () {
            $('#income').val(20);
            sharedObject.updateIncome();
            expect(sharedObject.income).to.be.equal(20);
        });

        it("should return previous value if value is 0", function () {
            sharedObject.changeIncome(15);
            $("#income").val("0");
            sharedObject.updateIncome();
            expect(sharedObject.income).to.equal(15);
            expect($("#income").val()).to.equal("0");
        });

    });
});
