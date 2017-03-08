<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>	Fibonacci Sequence </title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])) {
    $num = intval($_GET['num']);
    $fibonacciSeq;
    $fibonacciSeq[]=1;
    $fibonacciSeq[]=1;
    $f1=1;
    $f2=1;

    for ($i=0;$i<$num-2; $i++ ){
        $f3=$f1+$f2;
        $fibonacciSeq[]=$f3;
        $f1=$f2;
        $f2=$f3;
    }

    echo join(' ',$fibonacciSeq);
}
?>
</body>
</html>