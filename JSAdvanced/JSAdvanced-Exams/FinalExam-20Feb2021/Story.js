class Story {
    #comments;
    #likes;

    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
        this.#comments = [];
        this.#likes = [];
    };

    get likes() {
        if (this.#likes.length == 0) {
            return `${this.title} has 0 likes`;
        } else if (this.#likes.length == 1) {
            return `${this.#likes[0]} likes this story!`
        } else {
            return `${this.#likes[0]} and ${this.#likes.length - 1} others like this story!`;
        };
    };

    like(username) {
        if (this.#likes.includes(username)) {
            throw new Error("You can't like the same story twice!");
        };

        if (username == this.creator) {
            throw new Error("You can't like your own story!");
        };

        this.#likes.push(username);
        return `${username} liked ${this.title}!`;
    };

    dislike(username) {
        if (!this.#likes.includes(username)) {
            throw new Error("You can't dislike this story!");
        };

        
        this.#likes = this.#likes.filter(name => name !== username);
        return `${username} disliked ${this.title}`
    };

    comment(username, content, id) {

        if (!this.#comments.find(i => i.Id == id)) {
            let obj = {};
            obj.Id = this.#comments.length + 1;
            obj.Username = username;
            obj.Content = content;
            obj.Replies = [];
            this.#comments.push(obj);
            return `${username} commented on ${this.title}`;
        } else {
            let temp = this.#comments.find(i => i.Id == id);
            let obj = {};
            let count = temp.Replies.length

            if (count == 0) {
                obj.Id = Number(id + 0.1).toFixed(1);

            } else {
                obj.Id = Number(id + (count / 10) + 0.1).toFixed(1);
            };

            obj.Username = username;
            obj.Content = content;

            temp.Replies.push(obj);
            return `You replied successfully`;
        };
    };

    toString(sortingType) {
        let text = '';

        text += `Title: ${this.title}\n`;
        text += `Creator: ${this.creator}\n`;
        text += `Likes: ${this.#likes.length}\n`;
        text += `Comments:`

        if (this.#comments.length > 0) {
            if (sortingType == 'asc') {
                this.#comments.sort((a, b) => a.Id - b.Id);
            } else if (sortingType == 'desc') {
                this.#comments.sort((a, b) => b.Id - a.Id);
            } else {
                this.#comments.sort((a, b) => a.Username.localeCompare(b.Username));
            };
        };
        for (const comment of this.#comments) {

            text += `\n-- ${comment.Id}. ${comment.Username}: ${comment.Content}`;

            if (comment.Replies.length > 0) {

                if (sortingType == 'asc') {
                    comment.Replies.sort((a, b) => a.Id - b.Id);
                } else if (sortingType == 'desc') {
                    comment.Replies.sort((a, b) => b.Id - a.Id);
                } else {
                    comment.Replies.sort((a, b) => a.Username.localeCompare(b.Username));
                };

                for (const reply of comment.Replies) {

                    text += `\n--- ${reply.Id}. ${reply.Username}: ${reply.Content}`;
                };
            };
        };

        return text.trimEnd();
    };
};

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));

