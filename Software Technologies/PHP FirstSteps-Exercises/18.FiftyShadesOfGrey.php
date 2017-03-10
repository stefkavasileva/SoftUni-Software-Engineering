<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fifty Shades of Grey </title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php

for ($i = 0; $i <=204; $i+=51){
    for ($j = $i; $j <=$i+45; $j+=5) { ?>
        <div style="background-color: rgb(<?=$j?>,<?=$j?>,<?=$j?>)"></div>
   <?php } ?>
   <br/>
    <?php
}
?>
</body>
</html>