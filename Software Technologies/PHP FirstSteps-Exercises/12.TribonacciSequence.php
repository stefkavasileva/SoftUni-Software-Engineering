<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>	Tribonacci Sequence </title>

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
    $fibonacciSeq[]=2;
    $f1=1;
    $f2=1;
    $f3=2;
    for ($i=0;$i<$num-3; $i++ ){
        $f4=$f1+$f2+$f3;
        $fibonacciSeq[]=$f4;
        $f1=$f2;
        $f2=$f3;
        $f3=$f4;
    }

    echo join(' ',$fibonacciSeq);
}
?>
</body>
</html>