function extend(input){
    input.prototype.species = 'Human';
    input.prototype.toSpeciesString = function (){
        return `I am a ${this.species}. ${this.toString()}`
    }
}