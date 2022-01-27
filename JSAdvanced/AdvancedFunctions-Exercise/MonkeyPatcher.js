function solution(cmd) {

    let up = this.upvotes;
    let down = this.downvotes;
    if (cmd == 'upvote') {
        this.upvotes += 1;
    } else if (cmd == 'downvote') {
        this.downvotes += 1;
    } else {
        let arr = [];
        let sum = up + down;
        let balance = up - down;
        let add = 0;

        if (sum > 50) {
            if (up > down) {
                add = Math.ceil(up * 0.25);
            } else {
                add = Math.ceil(down * 0.25);
            }
            up += add;
            down += add;
        }
        arr.push(up);
        arr.push(down);
        arr.push(balance);

        if (up > sum * 0.66 && sum > 10) {
            arr.push('hot');
        } else if (balance >= 0 && (this.upvotes + this.downvotes > 100)) {
            arr.push('controversial');
        } else if (balance < 0) {
            arr.push('unpopular');
        } else {
            arr.push('new');
        }
        return arr;
    }
}


let post = {
    id: '1',
    author: 'pesho',
    content: 'hi guys',
    upvotes: 0,
    downvotes: 0
};
solution.call(post, 'upvote');
let score = solution.call(post, 'score');
console.log(score); 