class ArtGallery{
    constructor(creator){
        this.creator = creator;
        this.possibleArticles  = {
            picture: 200,
            photo: 50,
            item: 250
        };
        this.listOfArticles = [];
        this.guests = [];
    };

    addArticle( articleModel, articleName, quantity ){

        if (!Object.keys(this.possibleArticles).includes(articleModel.toLowerCase())) {
            throw new Error(`This article model is not included in this gallery!`);
        };

        let temp = this.listOfArticles.find(x => x.name == articleName);

        if (temp && temp.model == articleModel) {
            temp.quantity += quantity;
        }else{
            this.listOfArticles.push({
                model: articleModel.toLowerCase(),
                name: articleName,
                quantity: Number(quantity)
            })
        };

        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`
    };

    inviteGuest ( guestName, personality){
        if (this.guests.find(x => x.name == guestName)) {
            throw new Error(`${guestName} has already been invited.`);
        };

        let obj = {
            name: guestName,
            points: 0,
            purchaseArticle: 0

        };

        if (personality == "Vip") {
            obj.points = 500;
        }else if (personality == 'Middle'){
            obj.points = 250;
        }else{
            obj.points = 50;
        };

        this.guests.push(obj);
        return `You have successfully invited ${guestName}!`;
    };

    buyArticle ( articleModel, articleName, guestName){

        let temp = this.listOfArticles.find(x => x.name == articleName);
        let tempGuest = this.guests.find(x => x.name == guestName);
        if (!temp || temp.model.toLowerCase() != articleModel.toLowerCase()) {
            throw new Error('This article is not found.');
        };

        if (temp.quantity == 0) {
            return `The ${articleName} is not available.`
        }

        if (!tempGuest) {
            return `The guest is not invited.`
        };

        if (tempGuest.points < this.possibleArticles[articleModel]) {
            return 'You need to more points to purchase the article.';
        }else{

            tempGuest.points -= this.possibleArticles[articleModel];
            temp.quantity -= 1;
            tempGuest.purchaseArticle += 1;

            return `${guestName} successfully purchased the article worth ${this.possibleArticles[articleModel]} points.`
        };
    };

    showGalleryInfo (criteria){

        let text = '';
        if (criteria == 'article') {
            text += 'Articles information:'
            for (const item of this.listOfArticles) {
                
                text += `\n${item.model} - ${item.name} - ${item.quantity}`;
            };
            
        }else{
            text += 'Guests information:';

            for (const item of this.guests) {
                text += `\n${item.name} - ${item.purchaseArticle}`;
            };
        };

        return text;
    };
};

const artGallery = new ArtGallery('Curtis Mayfield');
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));



