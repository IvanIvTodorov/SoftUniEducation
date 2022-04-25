const {chromium} = require('playwright-chromium');
const { expect } = require('chai');

let browser, page;

describe('Msg Test', async function (){
    this.timeout(8000000);

    before(async () => { browser = await chromium.launch(); });
    after(async () => { await browser.close(); });
    beforeEach(async () => { page = await browser.newPage(); });
    afterEach(async () => { await page.close(); });

    it('Shows msg', async () => {
        await page.goto('http://localhost:5500');

        await page.click('id=refresh');
        await page.waitForResponse(/jsonstore\/messenger/i);

        const content = await page.value('#messages');

        expect(content).to.contain('Spami')
    });

});