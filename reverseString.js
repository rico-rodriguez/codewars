function solution(str){
    return (str === '') ? '' : solution(str.substr(1)) + str.charAt(0);

}
