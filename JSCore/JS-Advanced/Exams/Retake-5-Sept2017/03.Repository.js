//73/100
let Repository = (function () {
    let id = 0;

    class Repository {
        constructor(props) {
            this.props = props;
            this.data = new Map();
        }

        add(entity) {
            if(isValidEntity(entity,this.props)){
                this.data.set(id++,entity);
                return id;
            }
            /// pomisli za varqnt v koito moje v entrito da se podawat poveche parametri ot prop

        }

        update(inputId,entity){
            if(!this.data.has(inputId)){
                throw new Error(`Entity with id: ${inputId} does not exist!`);
            }

            if(isValidEntity(entity,this.props)){
                this.data.set(inputId,entity);
            }
        }

        del(inputId){
            if(!this.data.has(inputId)){
                throw new Error(`Entity with id: ${inputId} does not exist!`);
            }

            this.data.delete(inputId);
        }

        get(inputId){
            return this.data.get(inputId);
        }

        get count(){
            return this.data.size;
        }

    }

    function isValidEntity(entity,props){
        let propsKeys = Object.keys(props);
        for(let key of propsKeys){
            if(!entity.hasOwnProperty(key)){
                throw new Error (`Property ${key} is missing from the entity!`);
            }

            if(props[key] !== typeof entity[key]){
                throw new Error (`Property ${key} is of incorrect type!`);
            }
        }

        return true;
    }

    return Repository;
})();

// Initialize props object
let properties = {
    name: "string",
    age: "number",
    birthday: "object"
};
//Initialize the repository
let repository = new Repository(properties);
// Add two entities
let entity = {
    name: "Kiril",
    age: 19,
    birthday: new Date(1998, 0, 7)
};
repository.add(entity); // Returns 0
repository.add(entity); // Returns 1
console.log(repository.get(0));
// {"name":"Kiril","age":19,"birthday":"1998-01-06T22:00:00.000Z"}
console.log(repository.get(1));
// {"name":"Kiril","age":19,"birthday":"1998-01-06T22:00:00.000Z"}
//Update an entity
entity = {
    name: 'Valio',
    age: 19,
    birthday: new Date(1998, 0, 7)
};
repository.update(1, entity);
console.log(repository.get(1));
// {"name":"Valio","age":19,"birthday":"1998-01-06T22:00:00.000Z"}
// Delete an entity
repository.del(0);
console.log(repository.count); // Returns 1
let anotherEntity = {
    name1: 'Nakov',
    age: 26,
    birthday: new Date(1991, 0, 21)
};

