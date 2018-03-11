let expect = require('chai').expect;

let Sumator = require('../02.SumatorClass');

describe('Test Sumator class', function () {
    it('Has initial param', function () {
        let sumator = new Sumator();
        expect(sumator.hasOwnProperty('data')).to.be.equal(true);
        expect(Sumator.prototype.hasOwnProperty('add')).to.be.equal(true);
        expect(Sumator.prototype.hasOwnProperty('sumNums')).to.be.equal(true);
        expect(Sumator.prototype.hasOwnProperty('removeByFilter')).to.be.equal(true);
        expect(Sumator.prototype.hasOwnProperty('toString')).to.be.equal(true);
    });

    it('Has initial param', function () {
        let sumator = new Sumator();
        expect(sumator.data.length).to.be.equal(0);
    });

    it('Test add function',function(){
        let sumator = new Sumator();
        sumator.add(3);
        sumator.add(2);
        expect(sumator.data.length).to.be.equal(2);
    });

    it('Test add function with numbers and string',function(){
        let sumator = new Sumator();
        sumator.add(3);
        sumator.add(2);
        sumator.add('tests');
        expect(sumator.data.length).to.be.equal(3);
    });

    it('Test sumNums function',function(){
        let sumator = new Sumator();

        expect(sumator.sumNums()).to.be.equal(0); // ===> return 0 if arr if empty

        sumator.add(3);
        sumator.add(2);
        expect(sumator.sumNums()).to.be.equal(5);

        sumator.add('s');
        sumator.add('10'); //==> ignore if param is not a number
        expect(sumator.sumNums()).to.be.equal(5);

    });

    it('Test sumNums function',function(){
        let sumator = new Sumator();
        sumator.add(3);
        sumator.add(2);
        expect(sumator.sumNums()).to.be.equal(5);

    });

    it('Test sumNums function',function(){
        let sumator = new Sumator();

        sumator.add('s');
        sumator.add({}); //==> ignore if param is not a number
        expect(sumator.sumNums()).to.be.equal(0);

    });

    it('Test removeByFilter function',function(){
        let sumator = new Sumator();
        sumator.add(3);
        sumator.add(2);
        sumator.add(2);
        sumator.add(8);
        sumator.add(1);
        sumator.removeByFilter(x => x % 2 == 0);
        expect(sumator.sumNums()).to.be.equal(4);

        sumator.removeByFilter(x => x === 2);
        expect(sumator.sumNums()).to.be.equal(4);

        sumator.add(2);
        sumator.add(4);
        sumator.removeByFilter(x => x % 2 !== 0);
        expect(sumator.sumNums()).to.be.equal(6);



    });


    it('Test toString function',function(){
        let sumator = new Sumator();

        expect(sumator.toString()).to.be.equal('(empty)');

        sumator.add(3);
        sumator.add(2);
        expect(sumator.toString()).to.be.equal('3, 2');
    });

})