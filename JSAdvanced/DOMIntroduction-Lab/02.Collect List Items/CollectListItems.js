function extractText() {
    let extracted = document.getElementById("items").textContent;

    document.getElementById("result").textContent = Array.of(extracted).join("\n");
}