class Contact {
    constructor(first, second, number, mail) {
        this.name = `${first} ${second}`;
        this.number = number;
        this.mail = mail;
        this._online = false;
        this.div = document.createElement('div');
    };

    get online(){
        return this._online;
    };

    set online(value){

        this._online = value;

        if (this._online) {
            this.div.classList.add('online');
        }else{
            this.div.classList.remove('online');
        };
    };

    render(id){
        let article = document.createElement('article');

        this.div.classList.add('title');
        this.div.textContent = this.name;

        let btn = document.createElement('button');
        btn.textContent = '\u2139';

        this.div.appendChild(btn);

        let divInfo = document.createElement('div');
        divInfo.style.display = 'none';
        divInfo.classList.add('info');

        let spanTel = document.createElement('span');
        let spanMail = document.createElement('span');

        spanTel.textContent = `\u260E ${this.number}`;
        spanMail.textContent = `\u2709 ${this.mail}`;

        divInfo.appendChild(spanTel);
        divInfo.appendChild(spanMail);

        article.appendChild(this.div);
        article.appendChild(divInfo);

        document.getElementById(id).appendChild(article);

        btn.addEventListener('click', onClick);
        function onClick(ev){

            if (divInfo.style.display == 'block') {
                divInfo.style.display = 'none';
            }else{
                divInfo.style.display = 'block'
            }
        }
    }
}

let contacts = [
    new Contact("Ivan", "Ivanov", "0888 123 456", "i.ivanov@gmail.com"),
    new Contact("Maria", "Petrova", "0899 987 654", "mar4eto@abv.bg"),
    new Contact("Jordan", "Kirov", "0988 456 789", "jordk@gmail.com")
  ];
  contacts.forEach(c => c.render('main'));
  