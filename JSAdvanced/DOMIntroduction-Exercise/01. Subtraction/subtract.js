function subtract() {
    let first = Number(document.getElementById("firstNumber").tex);
    let second = Number(document.getElementById("secondNumber").value);

    document.getElementById('result').textContent = first - second;
}