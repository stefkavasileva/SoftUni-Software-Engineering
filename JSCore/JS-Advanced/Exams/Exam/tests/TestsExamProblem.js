let expect = require('chai').expect;

let PaymentPackage = require('../02.PaymentPackage');
describe('Test PaymentPackage class', function () {
    it('Has initial values', function () {
        expect(PaymentPackage.prototype.hasOwnProperty('name')).to.be.equal(true);
        expect(PaymentPackage.prototype.hasOwnProperty('value')).to.be.equal(true);
        expect(PaymentPackage.prototype.hasOwnProperty('VAT')).to.be.equal(true);
        expect(PaymentPackage.prototype.hasOwnProperty('active')).to.be.equal(true);
        expect(PaymentPackage.prototype.hasOwnProperty('toString')).to.be.equal(true);

    });

    it('Test with invalid params', function () {
        expect(() => new PaymentPackage()).to.throw();
        expect(() => new PaymentPackage(3,6,6)).to.throw();
        expect(() => new PaymentPackage({},'str',3)).to.throw();
    });


    it('Test Default value in obj', function () {
        let payment = new PaymentPackage('test', 20);

        expect(payment.name).to.not.be.undefined;
        expect(payment.value).to.not.be.undefined;
        expect(payment.VAT).to.not.be.undefined;
        expect(payment.active).to.not.be.undefined;
        expect(payment.toString()).to.not.be.undefined;

        expect(payment.VAT).to.be.equal(20);
        expect(payment.active).to.be.equal(true);

    });

    describe('Test name', function () {
        it('With no param should throw error', function () {
            expect(() => new PaymentPackage()).to.throw();
        });

        it('If it is not string should throw error', function () {
            expect(() => new PaymentPackage(3, 3)).to.throw();
        });

        it('If it is empty string should throw error', function () {
            expect(() => new PaymentPackage('', 3)).to.throw();
        });

        it('If it is not string should throw error', function () {
            expect(() => new PaymentPackage({}, 3)).to.throw();
        });

        it('If it is valid type should not throw error', function () {
            expect(() => new PaymentPackage('test', 3)).to.not.throw();
        });
    });

    describe('Test value param', function () {
        it('If it is not number should throw error', function () {
            expect(() => new PaymentPackage('test', '')).to.throw();
        });

        it('If it is not number should throw error', function () {
            expect(() => new PaymentPackage('test', {})).to.throw();
        });

        it('Without param should throw error', function () {
            expect(() => new PaymentPackage('test')).to.throw();
        });

        it('If it is a negative number should throw error', function () {
            expect(() => new PaymentPackage('test', -5)).to.throw();
        });

        it('With valid param should not throw error', function () {
            expect(() => new PaymentPackage('test', 5)).to.not.throw();
        });
    });

    describe('Test instance of a class', function () {
        let payment = new PaymentPackage('test', 2);
        payment.name = 'test';

        it('Test name', function () {
            expect(payment.name).to.be.equal('test');
            expect(() => payment.name = 3).to.throw();
            expect(() => payment.name = {}).to.throw();
            expect(() => payment.name = 'newName').to.not.throw();
            expect(() => payment.name = '').to.throw();
            expect(() => payment.name = null).to.throw();
            expect(() => payment.name = undefined).to.throw();
        });

        it('Test vat', function () {
            expect(() => payment.VAT = -3).to.throw();
            expect(() => payment.VAT = {}).to.throw();
            expect(() => payment.VAT = 'newName').to.throw();
            expect(() => payment.VAT = '').to.throw();
            expect(() => payment.VAT = null).to.throw();
            expect(() => payment.VAT = undefined).to.throw();
        });

        it('Test value', function () {
            expect(payment.value).to.be.equal(2);
            expect(() => payment.value = 3).to.not.throw();
            expect(() => payment.value = {}).to.throw();
            expect(() => payment.value = -6).to.throw();
            expect(() => payment.value = 'str').to.throw();
            expect(() => payment.value = null).to.throw();
            expect(() => payment.value = undefined).to.throw();
        });

        it('Test active param', function () {
            expect(payment.active).to.be.equal(true);
            expect(() => payment.active = 3).to.throw();
            expect(() => payment.active = {}).to.throw();
            expect(() => payment.active = -6).to.throw();
            expect(() => payment.active = 'str').to.throw();
            expect(() => payment.active = false).to.not.throw();
            expect(() => payment.active = null).to.throw();
            expect(() => payment.active = undefined).to.throw();
        });


        it('Test toString', function () {
            let pay = new PaymentPackage('test', 2);

            pay.active = true;
            expect(pay.toString()).to.be.equal('Package: test\n- Value (excl. VAT): 2\n- Value (VAT 20%): 2.4');

            pay.active = false;
            expect(pay.toString()).to.be.equal('Package: test (inactive)\n- Value (excl. VAT): 2\n- Value (VAT 20%): 2.4');
        });
    });
});