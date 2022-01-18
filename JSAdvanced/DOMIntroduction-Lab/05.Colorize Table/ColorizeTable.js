function colorize() {
    let elements = document.querySelectorAll("table tr");

    for (const index in elements) {
        if (index % 2 == 1) {
            elements[index].style.backgroundColor = "teal";
        }
    }
}