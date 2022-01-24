function solve() {
  let generateButton = document.getElementsByTagName('button')[0];
  let buyButton = document.getElementsByTagName('button')[1];
  let textarea = document.getElementsByTagName('textarea');
  let table = document.getElementsByTagName('tbody');

  generateButton.addEventListener('click', onClick);

  function onClick() {
    let obj = JSON.parse(textarea[0].value);

    for (const element of obj) {
      let image = document.createElement('img');
      image.src = element.img;
      let tdImage = document.createElement('td');
      tdImage.appendChild(image);

      let name = document.createElement('p');
      name.textContent = element.name;
      let tdName = document.createElement('td');
      tdName.appendChild(name);

      let price = document.createElement('p');
      price.textContent = element.price;
      let tdPrice = document.createElement('td');
      tdPrice.appendChild(price);

      let decorator = document.createElement('p');
      decorator.textContent = element.decFactor;
      let tdDecorator = document.createElement('td');
      tdDecorator.appendChild(decorator);

      let mark = document.createElement('input');
      mark.type = "checkbox";
      let tdMark = document.createElement('td');
      tdMark.appendChild(mark);

      let tr = document.createElement('tr');
      tr.appendChild(tdImage);
      tr.appendChild(tdName);
      tr.appendChild(tdPrice);
      tr.appendChild(tdDecorator);
      tr.appendChild(tdMark);

      table[0].appendChild(tr);
    }
  }
  buyButton.addEventListener('click', clicked);

  function clicked() {
    let newTable = document.getElementsByTagName('tr');
    let nameArr = [];
    let total = 0;
    let avgSum = 0;
    
    for (let index = 1; index < newTable.length; index++)
     {
      let lastElement = newTable[index].lastElementChild;
      let mark = lastElement.firstElementChild;

      let name = newTable[index].children[1].textContent;
      let price = Number(newTable[index].children[2].textContent);
      let decFactor = Number(newTable[index].children[3].textContent);
      
      if (mark.checked) {
        nameArr.push(name);
        total += price;
        avgSum += decFactor; 
      }
    }

    avgSum = avgSum / nameArr.length;

    let output = `Bought furniture: ${nameArr.join(", ")}\n`
    output += `Total price: ${total.toFixed(2)}\n`
    output += `Average decoration factor: ${avgSum}`

    textarea[1].textContent = output;
  }
}