const {mathEnforcer } = require('./MathEnforcer');
const { expect } = require('chai');

describe('Tests', () => {
    describe('add', () => {
        it('Incorrect param to add', () => {
            expect(mathEnforcer.addFive('a')).to.be.undefined;
        });

        it('Should return +5', () => {
            expect(mathEnforcer.addFive(0)).to.equal(5);
        });
        
        it("Add Five", function () {
            expect(mathEnforcer.addFive(0.5)).to.be.equal(5.5);        
        });
    
        it('Should return +5', () => {
            expect(mathEnforcer.addFive(-5)).to.equal(0);
        });

        it('Should return +5', () => {
            expect(mathEnforcer.addFive(-1)).to.equal(4);
        });

        it('Should return +5', () => {
            expect(mathEnforcer.addFive(-1.1)).to.be.closeTo(4, 0.2);
        });

        it('Should return +5', () => {
            expect(mathEnforcer.addFive(-10)).to.equal(-5);
        });
    });

    describe('subtract', () => {
        it('Incorrect param to subtract', () => {
            expect(mathEnforcer.subtractTen('a')).to.be.undefined;
        });

        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(10)).to.equal(0);
        });
    
        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(9)).to.equal(-1);
        });

        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
        });

        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(20)).to.equal(10);
        });

        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(-0.9)).to.be.closeTo(-11, 0.2);
        });
        it('Should return -10', () => {
            expect(mathEnforcer.subtractTen(11,5)).to.be.closeTo(1,5, 0);
        });
    });

    describe('sum', () => {
        it('Invalid sum param', () => {
            expect(mathEnforcer.sum('a', 5)).to.be.undefined;
        });
    
        it('Invalid sum param', () => {
            expect(mathEnforcer.sum(5, 'a')).to.be.undefined;
        });

        it('Invalid sum param', () => {
            expect(mathEnforcer.sum('a', 'a')).to.be.undefined;
        });

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(1,1)).to.equal(2);
        })
    
        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(-1,1)).to.equal(0);
        })
    
        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(1,-2)).to.equal(-1);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(5,-2)).to.equal(3);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(1.1, 1.1)).to.equal(2.2);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(-1.1, 1.1)).to.equal(0);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(1.1,- 1.1)).to.equal(0);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(1.1, 1.1)).to.be.closeTo(2, 0.3);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(-10, -10)).to.eq(-20);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(-1.1, -1.1)).to.equal(-2.2);
        })

        it('Should sum the nums', () => {
            expect(mathEnforcer.sum(-1.1, -1.1)).to.be.closeTo(-2, 0.3);
        })
    });
});