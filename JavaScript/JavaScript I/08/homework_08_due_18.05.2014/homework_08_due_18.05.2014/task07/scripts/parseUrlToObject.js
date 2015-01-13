///07. Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] 
///    and extracts from it the [protocol], [server] and [resource] elements. Return the elements in a JSON object.

var url,
    protocol,
    server,
    resource;

function solve() {
    url = document.getElementById('string-entry').value;
    url = parseUrlToObject(url);
    document.getElementById('result').innerHTML = 'Check browser console for the object!';
    console.dir(url);
}

function parseUrlToObject(urlAsString) {    
    protocol = urlAsString.substring(urlAsString, urlAsString.indexOf('://'));
    server = urlAsString.split('://');
    server = server[1];
    resource = server;
    server = server.substring(server, server.indexOf('/'));
    resource = resource.substring(resource.indexOf('/'), resource.length);

    return urlObject = {
        protocol: protocol,
        server: server,
        resource: resource
    };
}