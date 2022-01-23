function solve() {

  let answers = document.getElementsByClassName('answer-wrap');

  for (const answer of Array.from(answers)) {
    answer.addEventListener('click', onClick);
  }

  let blocks = document.getElementsByTagName('section');
  let result = document.getElementsByTagName('h1')[1];

  let curBlock = 0;
  let rightAnswers = 0;
  function onClick(ev) {
    let answer = ev.target.textContent;

    if (answer == "onclick" || answer == 'A programming API for HTML and XML documents' || answer == 'JSON.stringify()') {
      rightAnswers++;
    }

    blocks[curBlock].style.display = 'none';
    curBlock++

    if (curBlock < blocks.length) {
      blocks[curBlock].style.display = 'block';
    } else {
      document.getElementById('results').style.display = 'block';

      if (rightAnswers == blocks.length) {
        result.textContent = 'You are recognized as top JavaScript fan!'
      } else {
        result.textContent = `You have ${rightAnswers} right answers`
      }
    }
  }
}
