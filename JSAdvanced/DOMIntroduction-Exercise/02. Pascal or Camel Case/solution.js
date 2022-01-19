function solve() {

  let text = document.getElementById("text").value.split(" ");
  let parameter = document.getElementById('naming-convention').value;

  console.log(text);
  console.log(parameter);
  let result = '';
  let word = '';

  if (parameter != "Camel Case" && parameter != "Pascal Case") {
    result = "Error!";

  } else if (parameter == 'Pascal Case') {
    for (let index = 0; index < text.length; index++) {
      word = text[index];
      result += word[0].toUpperCase() + word.slice(1).toLowerCase();
    }
  } else {
    word = text[0];
    result += word[0].toLowerCase() + word.slice(1).toLowerCase();

    for (const word of text.splice(1)) {
      result += word[0].toUpperCase() + word.slice(1).toLowerCase();
    }
  }

  document.getElementById('result').textContent = result;
}