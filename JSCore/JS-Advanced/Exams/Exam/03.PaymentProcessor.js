class PaymentProcessor {
    constructor(options) {
        this.options = options;
        if (!options) {
            this.options = { types: ["service", "product", "other"], precision: 2
            }
        }else{
            if(!options.hasOwnProperty('types')){
                this.options['types'] = ["service", "product", "other"];
            }else {
                this.options['types'] = options['types'];
            }

            if(!options.hasOwnProperty('precision')){
                this.options['precision'] = 2;
            }else {
                this.options['precision'] = options['precision'];
            }
        }

        this.payments = [];
        this.balance = 0;
    }

    registerPayment(id, name, type, value) {
        if(id === '' ||
            name === '' ||
            typeof(value) !== 'number' ||
            !this.options.types.includes(type) ||
            this.payments.map(x=> x.id).includes(id)){

            throw new  Error('invalid type');
        }

        value = value.toFixed(Number(this.options.precision));

        this.payments.push({id,name,type,value});
        this.balance += Number(value);
    }

    deletePayment(id) {
        let payment;
        for(let currentPayment of this.payments){
            if(currentPayment.id === id){
                payment = currentPayment;
            }
        }

        if(!payment){
            throw new Error('ID not found');
        }

        this.balance -= Number(payment.value);
        for (let i =0; i < this.payments.length; i++)
            if (this.payments[i].id === payment.id) {
                this.payments.splice(i,1);
                break;
            }
    }

    get(id) {
        let payment;
        for(let currentPayment of this.payments){
            if(currentPayment.id === id){
                payment = currentPayment;
            }
        }

        if(payment === undefined){
            throw new Error('ID not found');
        }

        let result = `Details about payment ID: ${payment.id}\n`;
        result += `- Name: ${payment.name}\n`;
        result +=`- Type: ${payment.type}\n`;
        result += `- Value: ${payment.value}`;

        return result;
    }

    setOptions(options) {
        if(options.hasOwnProperty('types')){
            this.options.types = options.types;
        }

        if(options.hasOwnProperty('precision')){
            this.options.precision = options.precision;
        }
    }

    toString() {
        let result = `Summary:\n`;
        result += `- Payments: ${this.payments.length}:\n`;
        result += `- Balance: ${this.balance}`;

        return result;
    }
}


// Initialize processor with default options
const generalPayments = new PaymentProcessor();
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
generalPayments.registerPayment('01A3', 'Biopolymer', 'product', 23000);
console.log(generalPayments.toString());

// Should throw an error (invalid type)
//generalPayments.registerPayment('E028', 'Rare-earth elements', 'materials', 8000);

generalPayments.setOptions({types: ['product', 'material']});
generalPayments.registerPayment('E028', 'Rare-earth elements', 'material', 8000);
console.log(generalPayments.get('E028'));
generalPayments.registerPayment('CF15', 'Enzymes', 'material', 55000);

// Should throw an error (ID not found)
//generalPayments.deletePayment('E027');
// Should throw an error (ID not found)
//generalPayments.get('E027');

generalPayments.deletePayment('E028');
console.log(generalPayments.toString());

// Initialize processor with custom types
const servicePyaments = new PaymentProcessor({types: ['service']});
servicePyaments.registerPayment('01', 'HR Consultation', 'service', 3000);
servicePyaments.registerPayment('02', 'Discount', 'service', -1500);
console.log(servicePyaments.toString());

// Initialize processor with custom precision
const transactionLog = new PaymentProcessor({precision: 5});
transactionLog.registerPayment('b5af2d02-327e-4cbf', 'Interest', 'other', 0.00153);
console.log(transactionLog.toString());

