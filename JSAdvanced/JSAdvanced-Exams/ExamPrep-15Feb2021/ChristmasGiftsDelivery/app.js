function solution() {
    let text = document.getElementsByTagName('input')[0];
    let addGift = document.getElementsByTagName('button')[0];

    addGift.addEventListener('click', onClick);
    let ulList = document.getElementsByTagName('ul')[0];
    let ulSent = document.getElementsByTagName('ul')[1];
    let ulDiscard = document.getElementsByTagName('ul')[2];


    function onClick(){

        let li = document.createElement('li');
        li.classList.add('gift');
        li.textContent = text.value;

        let sendBtn = document.createElement('button');
        sendBtn.id = 'sendButton';
        sendBtn.textContent = 'Send';
        sendBtn.addEventListener('click', send);

        let discardBtn = document.createElement('button');
        discardBtn.id = 'discardButton';
        discardBtn.textContent = 'Discard';
        discardBtn.addEventListener('click', discard);

        li.appendChild(sendBtn);
        li.appendChild(discardBtn);

        ulList.appendChild(li);

        let arr = Array.from(ulList.children);
        arr.sort((a,b) => a.textContent.localeCompare(b.textContent));

        for (const li of arr) {
            ulList.appendChild(li);
        };

        text.value = '';

        function send(){
            sendBtn.remove();
            discardBtn.remove();

            ulSent.appendChild(li);
        };

        function discard(){
            sendBtn.remove();
            discardBtn.remove();

            ulDiscard.appendChild(li);
        };
    };
};