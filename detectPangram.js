function isPangram(string){
const stringify = Array.from(string)
const uppercased = stringify.map(stringify => stringify.toLowerCase());
const alphabet = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
const found = alphabet.every(r=> uppercased.includes(r))

return found === true ? true : false
}
