function findShort(s){
  let arr = s.split(" ")
  let i
  i =  arr.sort((a, b) => a.length - b.length)
  return i[0].length
}
