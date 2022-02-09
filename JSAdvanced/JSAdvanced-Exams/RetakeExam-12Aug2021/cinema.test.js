const {cinema} = require('./cinema');
const { expect } = require('chai');


describe('Cinema Tests', () => {
    describe('showMovies Tests', () => {
        it('No movies', () => {
            expect(cinema.showMovies([])).to.eq('There are currently no movies to show.');
        });

        it('With movies', () => {
            expect(cinema.showMovies(['Az, Ti'])).to.eq('Az, Ti');
        });

        it('With movies', () => {
            expect(cinema.showMovies([1,2,3,4])).to.eq('1, 2, 3, 4');
        });
    });

    describe('TicketPrice Tests', () => {
        it('Throws error', () => {
            expect(() => {
                cinema.ticketPrice('lalala');
            }).to.throw('Invalid projection type.');
        });

        it('Throws error', () => {
            expect(() => {
                cinema.ticketPrice('premiere');
            }).to.throw('Invalid projection type.');
        });

        it('Throws error', () => {
            expect(() => {
                cinema.ticketPrice('normal');
            }).to.throw('Invalid projection type.');
        });

        it('Throws error', () => {
            expect(() => {
                cinema.ticketPrice('discount');
            }).to.throw('Invalid projection type.');
        });


        it('Works properly with normal', () => {
            expect(cinema.ticketPrice('Normal')).to.eq(7.50);
        });
        it('Works properly with premiere', () => {
            expect(cinema.ticketPrice('Premiere')).to.eq(12.00);
        });
        it('Works properly with discount', () => {
            expect(cinema.ticketPrice('Discount')).to.eq(5.50);
        });
    });

    describe('SwapSeats Tests', () => {
        it('Not an integer first', () => {
            expect(cinema.swapSeatsInHall(2.2, 2)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('Not an integer second', () => {
            expect(cinema.swapSeatsInHall(2, 2.2)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('Negative first', () => {
            expect(cinema.swapSeatsInHall(0, 2)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('Negative second', () => {
            expect(cinema.swapSeatsInHall(2, 0)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('More than 20 first', () => {
            expect(cinema.swapSeatsInHall(21, 2)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('More than 20 second', () => {
            expect(cinema.swapSeatsInHall(2, 21)).to.eq('Unsuccessful change of seats in the hall.');
        });

        it('Even', () => {
            expect(cinema.swapSeatsInHall(20, 20)).to.eq('Unsuccessful change of seats in the hall.');
        }); 
        
        it('Succsess', () => {
            expect(cinema.swapSeatsInHall(3, 2)).to.eq('Successful change of seats in the hall.');
        });

        it('Succsess', () => {
            expect(cinema.swapSeatsInHall(19, 20)).to.eq('Successful change of seats in the hall.');
        });
    });
});