/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    let str = s.toLowerCase().replace(/\s/g, "").replace(/[^a-zA-Z0-9 ]/g, "")
    let reverse = str.toLowerCase().replace(/\s/g, "").replace(/[^a-zA-Z0-9 ]/g, "").split("").reverse().join("");
    console.log(reverse)
    
    return reverse == str ? true : false
};
