async function loadCommits() {
    let username = document.getElementById('username').value;
    let repo = document.getElementById('repo').value;
    let commits = document.getElementById('commits');

    try {
        let response = await fetch(`https://api.github.com/repos/${username}/${repo}/commits`);
        console.log(response);
        if (response.ok == false) {
            throw new Error(`${response.status}`);
        };

        let data = await response.json();
        console.log(data);
        commits.innerHTML = '';

        for (const item of data) {

            let li = document.createElement('li');

            li.textContent = `${item.commit.author.name}: ${item.commit.message}`;

            commits.appendChild(li);
        }
    } catch (error) {
        commits.innerHTML = '';
        let li = document.createElement('li');

        li.textContent = `Error: ${error.message} (Not Found)`;

        commits.appendChild(li);
    }
};