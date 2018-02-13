function filterByAge(minAge,fistPersonName,firstPersonAge,secondPersonName,secondPersonAge) {
   let fistPerson =  {name:fistPersonName,age: firstPersonAge};
   let secondPerson = {name: secondPersonName,age: secondPersonAge};

   let people =  [fistPerson,secondPerson];
   people = people.filter(x => x.age >= minAge);

   for(let index in people){
       console.log(people[index]);
   }
}

filterByAge(12, 'Ivan', 15, 'Asen', 9);