function getArticleGenerator(articles) {
    let temp = articles;
    let div = document.getElementById('content');

    return function solve() {
        let init = temp.shift();
        if (init) {
            let article = document.createElement('article');
            article.textContent = init;
            div.appendChild(article);
        }
    }
}
