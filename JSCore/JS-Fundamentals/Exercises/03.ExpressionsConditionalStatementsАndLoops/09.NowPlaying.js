function print([trackName,artistName,duration]) {
    let result = `Now Playing: ${artistName} - ${trackName} [${duration}]`;

    console.log(result);
}

print(['Number One', 'Nelly', '4:09']);