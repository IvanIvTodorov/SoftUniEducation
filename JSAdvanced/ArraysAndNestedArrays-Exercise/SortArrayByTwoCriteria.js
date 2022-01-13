function sortArray(input) {

    input.sort(function(a,b) {
       return a.length - b.length || a.localeCompare(b)
    })

    console.log(input.join('\n'))
}

sortArray(['alpha',
    'beta',
    'gamma']
)