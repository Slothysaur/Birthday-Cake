fun main() {
    fun printCakeTop(age: Int) {
        repeat(age + 2) {
            print("=")
    }
    println()    
 }
    fun printCakeCandles(age: Int) {
       print(" ")
       repeat(age) {
            print(",")
        }
        println()
        
        print(" ")
        repeat(age){
            print("|")
        }
        println()
    }
    fun printCakeBottom(age: Int, layers: Int){
        repeat(layers){
            repeat(age + 2){
               print("@")
        }
        println()
    }
    }
    
    var age = 30
    var layers = 5
    printCakeCandles(age)
    printCakeTop(age)
    printCakeBottom(age,layers)
}
