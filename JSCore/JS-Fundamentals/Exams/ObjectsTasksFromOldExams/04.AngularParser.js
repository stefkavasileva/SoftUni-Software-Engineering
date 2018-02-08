function parseAngularData(inputArgs) {
    let modules = {};
    let elementToBeAddInModules = [];

    for (let i = 0; i < inputArgs.length; i++) {
        let args = inputArgs[i].split(/['=]/g).filter(x => x !== '');
        let elementType = args[0];
        if(elementType === '$app'){
            let moduleName = args[1];

            if(!modules.hasOwnProperty(moduleName)){
                modules[moduleName] =  {controllers: [],models: [],views: []};
            }
        }else {
            let moduleName = args[3];
            if(modules.hasOwnProperty(moduleName)){
                let isAdded = addElementIfPossible(elementType,modules,args[1],moduleName);
                if(!isAdded){
                   elementToBeAddInModules.push(inputArgs[i]);
                }
            }else{
                elementToBeAddInModules.push(inputArgs[i]);
            }
        }
    }

    for (let currentElement of elementToBeAddInModules) {
        let currentElementArgs = currentElement.split(/['=]/g).filter(x => x !== '');
        let moduleName = currentElementArgs[3];
        if(modules.hasOwnProperty(moduleName)){
            addElementIfPossible(currentElementArgs[0],modules,currentElementArgs[1],moduleName);
        }
    }

    for (const value of Object.values(modules)) {
        value.controllers.sort((a,b) => a.localeCompare(b));
        value.models.sort((a,b) => a.localeCompare(b));
        value.views.sort((a,b) => a.localeCompare(b));
    }

    let sortedModulesKeys = Object.keys(modules).sort(sortModules);
    let sortedModules = {};
    for (let key of sortedModulesKeys) {
        sortedModules[key] = modules[key];
    }

    console.log(JSON.stringify(sortedModules));

    function sortModules(a,b) {
        let controllersLengthA = modules[a].controllers.length;
        let controllersLengthB = modules[b].controllers.length;
        if(controllersLengthA > controllersLengthB){
            return -1;
        }else if(controllersLengthA < controllersLengthB){
            return 1;
        }else {
            let modelsLengthA = modules[a].models.length;
            let modelsLengthB = modules[b].models.length;
            if(modelsLengthA > modelsLengthB){
                return 1;
            }else{
                return -1
            }
        }
    }

    function addElementIfPossible(elementType,modules,elementName,moduleName) {
       let isAdded = false;
        switch (elementType){
           case "$controller":
               let controller = modules[moduleName].controllers.find(x => x === elementName);
               if(!controller){
                   controller = elementName;
               }
               modules[moduleName].controllers.push(controller);
               isAdded = true;
               break;
            case "$model":
                let model = modules[moduleName].models.find(x => x === elementName);
                if(!model){
                    model = elementName;
                }
                modules[moduleName].models.push(model);
                isAdded = true;
                break;
            case "$view":
                let view = modules[moduleName].views.find(x => x === elementName);
                if(!view){
                    view = elementName;
                }
                modules[moduleName].views.push(view);
                isAdded = true;
                break;
       }
       return isAdded;
   }
}

parseAngularData(['$controller=\'PHPController\'&app=\'Language Parser\'' ,
'$controller=\'JavaController\'&app=\'Language Parser\'' ,
'$controller=\'C#Controller\'&app=\'Language Parser\'' ,
'$controller=\'C++Controller\'&app=\'Language Parser\'' ,
'$app=\'Garbage Collector\'' ,
'$controller=\'GarbageController\'&app=\'Garbage Collector\'' ,
'$controller=\'SpamController\'&app=\'Garbage Collector\'' ,
'$app=\'Language Parser\'']);