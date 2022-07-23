/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
    var o = s.split(" ");
    var n = o.filter(n => n) 

    console.log(n)
    return n[n.length-1].length;
};
