function constructionCrew(person) {
    if(person.hasOwnProperty('handsShaking') && person['handsShaking']){
        person['bloodAlcoholLevel'] += 0.1 * person['weight'] * person['experience'];
        person['handsShaking'] = false;
    }

    return person;
}

console.log(constructionCrew({
    weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true

}));;