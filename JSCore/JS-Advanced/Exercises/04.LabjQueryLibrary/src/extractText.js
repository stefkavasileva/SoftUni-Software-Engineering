function extractText() {
   $('#result').text($('#items li').toArray().map((a,b) => $(a).text()).join(', '));
}
