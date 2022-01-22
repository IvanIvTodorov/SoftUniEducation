function encodeAndDecodeMessages() {
    let buttons = document.getElementsByTagName('button');

    for (const button of buttons) {
        button.addEventListener('click', onClick);
    }

    let textareas = document.getElementsByTagName('textarea');

    function onClick(ev) {
        let decoded = '';
        let encoded = '';
        let num = 0;

        if (ev.target.textContent === 'Encode and send it') {
            encoded = textareas[0].value;
            textareas[0].value = "";
            for (let index = 0; index < encoded.length; index++) {
                num = encoded[index].codePointAt() + 1;
                decoded += String.fromCharCode(num);
            }

            textareas[1].textContent = decoded;
        } else {       
            decoded = textareas[1].textContent;

            for (let index = 0; index < decoded.length; index++) {
                num = decoded[index].codePointAt() - 1;
                encoded += String.fromCharCode(num);

            }

            textareas[1].textContent = encoded;
        }
    }
}