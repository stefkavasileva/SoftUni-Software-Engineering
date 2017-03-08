<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title> Numbers from N to 1 </title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $number=intval($_GET['num']);
    $numbers;
    for ($i =$number ; $i>0;$i--){
        $numbers[]=$i;
    }

    echo join(' ',$numbers);
}
?>
</body>
</html>