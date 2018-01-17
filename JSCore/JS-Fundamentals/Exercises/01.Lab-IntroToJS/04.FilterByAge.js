function fileterByAge(minAge,fistPersonName,firstPersonAge,secondPersonName,secondPersonAge) {
   let fistPerson =  {name:fistPersonName,age: firstPersonAge};
   let seconPerson = {name: secondPersonName,age: secondPersonAge};

   let people =  [fistPerson,seconPerson];
   people = people.filter(x => x.age >= minAge);

   for(let index in people){
       console.log(people[index]);
   }
}

fileterByAge(12, 'Ivan', 15, 'Asen', 9);