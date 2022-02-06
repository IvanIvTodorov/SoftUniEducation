const {PaymentPackage} = require('./PaymentPackage.js');
const { expect,assert } = require('chai');

describe('Tests', () => {
    let current;

    beforeEach(() => {
        current = new PaymentPackage('Ivan', 5);
    });
    
    describe('Test Constructor', () => {
        it('Test Constructor name', () =>{
            expect(current.name).to.eq('Ivan');
        });
    
        it('Test Constructor value', () =>{
            expect(current.value).to.eq(5);
        });
    
        it('Test Constructor vat', () =>{
            expect(current.VAT).to.eq(20);
        });
    
        it('Test Constructor name', () =>{
            expect(current.active).to.be.true;
        });    
    });
   

    it('Test name', () => {
        current.name = 'Jhon';
        expect(current.name).to.eq('Jhon');
    });

    it('Test name throws error', () => {
        expect(() => {
            current.name = 5;
        }).to.throw('Name must be a non-empty string');
    });

    it('Test name throws error', () => {
        expect(() => {
            current.name = '';
        }).to.throw('Name must be a non-empty string');
    });

    it('Test value throws error', () => {
        expect(() => {
            current.value = '';
        }).to.throw('Value must be a non-negative number');
    });

    it('Test value throws error', () => {
        expect(() => {
            current.value = -1;
        }).to.throw('Value must be a non-negative number');
    });

    it('Test value', () => {
        current.value = 6;
        expect(current.value).to.eq(6);
    });

    it('Test vat throws error', () => {
        expect(() => {
            current.VAT = '';
        }).to.throw('VAT must be a non-negative number');
    });

    it('Test vat throws error', () => {
        expect(() => {
            current.VAT = -1;
        }).to.throw('VAT must be a non-negative number');
    });

    it('Test vat', () => {
        current.VAT = 6;
        expect(current.VAT).to.eq(6);
    });
    
    it('Test active', () => {
        current.active = false;
        expect(current.active).to.be.false;
    });

    it('Test active', () => {
        expect(current.active).to.be.true;
    });

    it('Test active throws error', () => {  
        expect(() => {
            current.active = 5;
        }).to.throw('Active status must be a boolean')
    });

    it('Test toString', () => {
        const test = [
            `Package: ${current.name}` + (current.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${current.value}`,
            `- Value (VAT ${current.VAT}%): ${current.value * (1 + current.VAT / 100)}`
        ];
        expect(current.toString()).to.eq(test.join('\n'));
    })

    it('Test toString', () => {
        current.active = false;
        const test = [
            `Package: ${current.name}` + (current.active === false ? ' (inactive)' : ''),
            `- Value (excl. VAT): ${current.value}`,
            `- Value (VAT ${current.VAT}%): ${current.value * (1 + current.VAT / 100)}`
        ];
        expect(current.toString()).to.eq(test.join('\n'));
    })
});
  