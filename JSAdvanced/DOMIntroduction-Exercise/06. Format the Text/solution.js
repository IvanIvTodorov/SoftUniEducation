function solve() {
  let text = document.getElementById('input').value;

  temp = text.split('.').filter(x => x.length > 0);

  let tag = '';

  while (temp.length > 0) {
    let paragraph = '';
    for (let index = 0; index < 3; index++) {
      if (temp.length == 0) {
        break;
      }
      paragraph += temp.shift() + ".";
    }
    tag = document.createElement('p');
    tag.appendChild(document.createTextNode(paragraph));
    document.getElementById("output").appendChild(tag);

  }
}