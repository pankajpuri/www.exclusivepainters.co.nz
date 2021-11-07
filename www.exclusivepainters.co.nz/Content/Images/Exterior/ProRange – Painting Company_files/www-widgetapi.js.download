(function(){/*

 Copyright The Closure Library Authors.
 SPDX-License-Identifier: Apache-2.0
*/
var r;function aa(a){var b=0;return function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}}}
var ba="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(a==Array.prototype||a==Object.prototype)return a;a[b]=c.value;return a};
function ca(a){a=["object"==typeof globalThis&&globalThis,a,"object"==typeof window&&window,"object"==typeof self&&self,"object"==typeof global&&global];for(var b=0;b<a.length;++b){var c=a[b];if(c&&c.Math==Math)return c}throw Error("Cannot find global object");}
var da=ca(this);function t(a,b){if(b)a:{for(var c=da,d=a.split("."),e=0;e<d.length-1;e++){var f=d[e];if(!(f in c))break a;c=c[f]}d=d[d.length-1];e=c[d];f=b(e);f!=e&&null!=f&&ba(c,d,{configurable:!0,writable:!0,value:f})}}
t("Symbol",function(a){function b(e){if(this instanceof b)throw new TypeError("Symbol is not a constructor");return new c("jscomp_symbol_"+(e||"")+"_"+d++,e)}
function c(e,f){this.h=e;ba(this,"description",{configurable:!0,writable:!0,value:f})}
if(a)return a;c.prototype.toString=function(){return this.h};
var d=0;return b});
t("Symbol.iterator",function(a){if(a)return a;a=Symbol("Symbol.iterator");for(var b="Array Int8Array Uint8Array Uint8ClampedArray Int16Array Uint16Array Int32Array Uint32Array Float32Array Float64Array".split(" "),c=0;c<b.length;c++){var d=da[b[c]];"function"===typeof d&&"function"!=typeof d.prototype[a]&&ba(d.prototype,a,{configurable:!0,writable:!0,value:function(){return ea(aa(this))}})}return a});
function ea(a){a={next:a};a[Symbol.iterator]=function(){return this};
return a}
function u(a){var b="undefined"!=typeof Symbol&&Symbol.iterator&&a[Symbol.iterator];return b?b.call(a):{next:aa(a)}}
var fa="function"==typeof Object.create?Object.create:function(a){function b(){}
b.prototype=a;return new b},ha;
if("function"==typeof Object.setPrototypeOf)ha=Object.setPrototypeOf;else{var ia;a:{var ja={a:!0},ka={};try{ka.__proto__=ja;ia=ka.a;break a}catch(a){}ia=!1}ha=ia?function(a,b){a.__proto__=b;if(a.__proto__!==b)throw new TypeError(a+" is not extensible");return a}:null}var la=ha;
function y(a,b){a.prototype=fa(b.prototype);a.prototype.constructor=a;if(la)la(a,b);else for(var c in b)if("prototype"!=c)if(Object.defineProperties){var d=Object.getOwnPropertyDescriptor(b,c);d&&Object.defineProperty(a,c,d)}else a[c]=b[c];a.A=b.prototype}
function ma(){this.o=!1;this.j=null;this.i=void 0;this.h=1;this.u=this.m=0;this.l=null}
function na(a){if(a.o)throw new TypeError("Generator is already running");a.o=!0}
ma.prototype.s=function(a){this.i=a};
function oa(a,b){a.l={X:b,ra:!0};a.h=a.m||a.u}
ma.prototype["return"]=function(a){this.l={"return":a};this.h=this.u};
function z(a,b,c){a.h=c;return{value:b}}
function pa(a){a.m=0;var b=a.l.X;a.l=null;return b}
function qa(a){this.h=new ma;this.i=a}
function ra(a,b){na(a.h);var c=a.h.j;if(c)return sa(a,"return"in c?c["return"]:function(d){return{value:d,done:!0}},b,a.h["return"]);
a.h["return"](b);return ta(a)}
function sa(a,b,c,d){try{var e=b.call(a.h.j,c);if(!(e instanceof Object))throw new TypeError("Iterator result "+e+" is not an object");if(!e.done)return a.h.o=!1,e;var f=e.value}catch(g){return a.h.j=null,oa(a.h,g),ta(a)}a.h.j=null;d.call(a.h,f);return ta(a)}
function ta(a){for(;a.h.h;)try{var b=a.i(a.h);if(b)return a.h.o=!1,{value:b.value,done:!1}}catch(c){a.h.i=void 0,oa(a.h,c)}a.h.o=!1;if(a.h.l){b=a.h.l;a.h.l=null;if(b.ra)throw b.X;return{value:b["return"],done:!0}}return{value:void 0,done:!0}}
function ua(a){this.next=function(b){na(a.h);a.h.j?b=sa(a,a.h.j.next,b,a.h.s):(a.h.s(b),b=ta(a));return b};
this["throw"]=function(b){na(a.h);a.h.j?b=sa(a,a.h.j["throw"],b,a.h.s):(oa(a.h,b),b=ta(a));return b};
this["return"]=function(b){return ra(a,b)};
this[Symbol.iterator]=function(){return this}}
function A(a,b){var c=new ua(new qa(b));la&&a.prototype&&la(c,a.prototype);return c}
t("Reflect.setPrototypeOf",function(a){return a?a:la?function(b,c){try{return la(b,c),!0}catch(d){return!1}}:null});
function va(a,b,c){if(null==a)throw new TypeError("The 'this' value for String.prototype."+c+" must not be null or undefined");if(b instanceof RegExp)throw new TypeError("First argument to String.prototype."+c+" must not be a regular expression");return a+""}
t("String.prototype.endsWith",function(a){return a?a:function(b,c){var d=va(this,b,"endsWith");b+="";void 0===c&&(c=d.length);for(var e=Math.max(0,Math.min(c|0,d.length)),f=b.length;0<f&&0<e;)if(d[--e]!=b[--f])return!1;return 0>=f}});
t("String.prototype.startsWith",function(a){return a?a:function(b,c){var d=va(this,b,"startsWith");b+="";for(var e=d.length,f=b.length,g=Math.max(0,Math.min(c|0,d.length)),h=0;h<f&&g<e;)if(d[g++]!=b[h++])return!1;return h>=f}});
t("Object.setPrototypeOf",function(a){return a||la});
function B(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
var wa="function"==typeof Object.assign?Object.assign:function(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(d)for(var e in d)B(d,e)&&(a[e]=d[e])}return a};
t("Object.assign",function(a){return a||wa});
t("Promise",function(a){function b(g){this.h=0;this.j=void 0;this.i=[];this.s=!1;var h=this.l();try{g(h.resolve,h.reject)}catch(k){h.reject(k)}}
function c(){this.h=null}
function d(g){return g instanceof b?g:new b(function(h){h(g)})}
if(a)return a;c.prototype.i=function(g){if(null==this.h){this.h=[];var h=this;this.j(function(){h.m()})}this.h.push(g)};
var e=da.setTimeout;c.prototype.j=function(g){e(g,0)};
c.prototype.m=function(){for(;this.h&&this.h.length;){var g=this.h;this.h=[];for(var h=0;h<g.length;++h){var k=g[h];g[h]=null;try{k()}catch(l){this.l(l)}}}this.h=null};
c.prototype.l=function(g){this.j(function(){throw g;})};
b.prototype.l=function(){function g(l){return function(m){k||(k=!0,l.call(h,m))}}
var h=this,k=!1;return{resolve:g(this.ea),reject:g(this.m)}};
b.prototype.ea=function(g){if(g===this)this.m(new TypeError("A Promise cannot resolve to itself"));else if(g instanceof b)this.ga(g);else{a:switch(typeof g){case "object":var h=null!=g;break a;case "function":h=!0;break a;default:h=!1}h?this.da(g):this.o(g)}};
b.prototype.da=function(g){var h=void 0;try{h=g.then}catch(k){this.m(k);return}"function"==typeof h?this.ha(h,g):this.o(g)};
b.prototype.m=function(g){this.u(2,g)};
b.prototype.o=function(g){this.u(1,g)};
b.prototype.u=function(g,h){if(0!=this.h)throw Error("Cannot settle("+g+", "+h+"): Promise already settled in state"+this.h);this.h=g;this.j=h;2===this.h&&this.fa();this.C()};
b.prototype.fa=function(){var g=this;e(function(){if(g.D()){var h=da.console;"undefined"!==typeof h&&h.error(g.j)}},1)};
b.prototype.D=function(){if(this.s)return!1;var g=da.CustomEvent,h=da.Event,k=da.dispatchEvent;if("undefined"===typeof k)return!0;"function"===typeof g?g=new g("unhandledrejection",{cancelable:!0}):"function"===typeof h?g=new h("unhandledrejection",{cancelable:!0}):(g=da.document.createEvent("CustomEvent"),g.initCustomEvent("unhandledrejection",!1,!0,g));g.promise=this;g.reason=this.j;return k(g)};
b.prototype.C=function(){if(null!=this.i){for(var g=0;g<this.i.length;++g)f.i(this.i[g]);this.i=null}};
var f=new c;b.prototype.ga=function(g){var h=this.l();g.O(h.resolve,h.reject)};
b.prototype.ha=function(g,h){var k=this.l();try{g.call(h,k.resolve,k.reject)}catch(l){k.reject(l)}};
b.prototype.then=function(g,h){function k(q,p){return"function"==typeof q?function(v){try{l(q(v))}catch(w){m(w)}}:p}
var l,m,n=new b(function(q,p){l=q;m=p});
this.O(k(g,l),k(h,m));return n};
b.prototype["catch"]=function(g){return this.then(void 0,g)};
b.prototype.O=function(g,h){function k(){switch(l.h){case 1:g(l.j);break;case 2:h(l.j);break;default:throw Error("Unexpected state: "+l.h);}}
var l=this;null==this.i?f.i(k):this.i.push(k);this.s=!0};
b.resolve=d;b.reject=function(g){return new b(function(h,k){k(g)})};
b.race=function(g){return new b(function(h,k){for(var l=u(g),m=l.next();!m.done;m=l.next())d(m.value).O(h,k)})};
b.all=function(g){var h=u(g),k=h.next();return k.done?d([]):new b(function(l,m){function n(v){return function(w){q[v]=w;p--;0==p&&l(q)}}
var q=[],p=0;do q.push(void 0),p++,d(k.value).O(n(q.length-1),m),k=h.next();while(!k.done)})};
return b});
t("Object.is",function(a){return a?a:function(b,c){return b===c?0!==b||1/b===1/c:b!==b&&c!==c}});
t("Array.prototype.includes",function(a){return a?a:function(b,c){var d=this;d instanceof String&&(d=String(d));var e=d.length,f=c||0;for(0>f&&(f=Math.max(f+e,0));f<e;f++){var g=d[f];if(g===b||Object.is(g,b))return!0}return!1}});
t("String.prototype.includes",function(a){return a?a:function(b,c){return-1!==va(this,b,"includes").indexOf(b,c||0)}});
t("Object.entries",function(a){return a?a:function(b){var c=[],d;for(d in b)B(b,d)&&c.push([d,b[d]]);return c}});
function xa(a,b){a instanceof String&&(a+="");var c=0,d=!1,e={next:function(){if(!d&&c<a.length){var f=c++;return{value:b(f,a[f]),done:!1}}d=!0;return{done:!0,value:void 0}}};
e[Symbol.iterator]=function(){return e};
return e}
t("Array.prototype.entries",function(a){return a?a:function(){return xa(this,function(b,c){return[b,c]})}});
t("Array.prototype.keys",function(a){return a?a:function(){return xa(this,function(b){return b})}});
t("Array.prototype.values",function(a){return a?a:function(){return xa(this,function(b,c){return c})}});
t("WeakMap",function(a){function b(k){this.h=(h+=Math.random()+1).toString();if(k){k=u(k);for(var l;!(l=k.next()).done;)l=l.value,this.set(l[0],l[1])}}
function c(){}
function d(k){var l=typeof k;return"object"===l&&null!==k||"function"===l}
function e(k){if(!B(k,g)){var l=new c;ba(k,g,{value:l})}}
function f(k){var l=Object[k];l&&(Object[k]=function(m){if(m instanceof c)return m;Object.isExtensible(m)&&e(m);return l(m)})}
if(function(){if(!a||!Object.seal)return!1;try{var k=Object.seal({}),l=Object.seal({}),m=new a([[k,2],[l,3]]);if(2!=m.get(k)||3!=m.get(l))return!1;m["delete"](k);m.set(l,4);return!m.has(k)&&4==m.get(l)}catch(n){return!1}}())return a;
var g="$jscomp_hidden_"+Math.random();f("freeze");f("preventExtensions");f("seal");var h=0;b.prototype.set=function(k,l){if(!d(k))throw Error("Invalid WeakMap key");e(k);if(!B(k,g))throw Error("WeakMap key fail: "+k);k[g][this.h]=l;return this};
b.prototype.get=function(k){return d(k)&&B(k,g)?k[g][this.h]:void 0};
b.prototype.has=function(k){return d(k)&&B(k,g)&&B(k[g],this.h)};
b.prototype["delete"]=function(k){return d(k)&&B(k,g)&&B(k[g],this.h)?delete k[g][this.h]:!1};
return b});
t("Number.isNaN",function(a){return a?a:function(b){return"number"===typeof b&&isNaN(b)}});
t("Map",function(a){function b(){var h={};return h.previous=h.next=h.head=h}
function c(h,k){var l=h.h;return ea(function(){if(l){for(;l.head!=h.h;)l=l.previous;for(;l.next!=l.head;)return l=l.next,{done:!1,value:k(l)};l=null}return{done:!0,value:void 0}})}
function d(h,k){var l=k&&typeof k;"object"==l||"function"==l?f.has(k)?l=f.get(k):(l=""+ ++g,f.set(k,l)):l="p_"+k;var m=h.i[l];if(m&&B(h.i,l))for(var n=0;n<m.length;n++){var q=m[n];if(k!==k&&q.key!==q.key||k===q.key)return{id:l,list:m,index:n,v:q}}return{id:l,list:m,index:-1,v:void 0}}
function e(h){this.i={};this.h=b();this.size=0;if(h){h=u(h);for(var k;!(k=h.next()).done;)k=k.value,this.set(k[0],k[1])}}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var h=Object.seal({x:4}),k=new a(u([[h,"s"]]));if("s"!=k.get(h)||1!=k.size||k.get({x:4})||k.set({x:4},"t")!=k||2!=k.size)return!1;var l=k.entries(),m=l.next();if(m.done||m.value[0]!=h||"s"!=m.value[1])return!1;m=l.next();return m.done||4!=m.value[0].x||"t"!=m.value[1]||!l.next().done?!1:!0}catch(n){return!1}}())return a;
var f=new WeakMap;e.prototype.set=function(h,k){h=0===h?0:h;var l=d(this,h);l.list||(l.list=this.i[l.id]=[]);l.v?l.v.value=k:(l.v={next:this.h,previous:this.h.previous,head:this.h,key:h,value:k},l.list.push(l.v),this.h.previous.next=l.v,this.h.previous=l.v,this.size++);return this};
e.prototype["delete"]=function(h){h=d(this,h);return h.v&&h.list?(h.list.splice(h.index,1),h.list.length||delete this.i[h.id],h.v.previous.next=h.v.next,h.v.next.previous=h.v.previous,h.v.head=null,this.size--,!0):!1};
e.prototype.clear=function(){this.i={};this.h=this.h.previous=b();this.size=0};
e.prototype.has=function(h){return!!d(this,h).v};
e.prototype.get=function(h){return(h=d(this,h).v)&&h.value};
e.prototype.entries=function(){return c(this,function(h){return[h.key,h.value]})};
e.prototype.keys=function(){return c(this,function(h){return h.key})};
e.prototype.values=function(){return c(this,function(h){return h.value})};
e.prototype.forEach=function(h,k){for(var l=this.entries(),m;!(m=l.next()).done;)m=m.value,h.call(k,m[1],m[0],this)};
e.prototype[Symbol.iterator]=e.prototype.entries;var g=0;return e});
t("Set",function(a){function b(c){this.h=new Map;if(c){c=u(c);for(var d;!(d=c.next()).done;)this.add(d.value)}this.size=this.h.size}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var c=Object.seal({x:4}),d=new a(u([c]));if(!d.has(c)||1!=d.size||d.add(c)!=d||1!=d.size||d.add({x:4})!=d||2!=d.size)return!1;var e=d.entries(),f=e.next();if(f.done||f.value[0]!=c||f.value[1]!=c)return!1;f=e.next();return f.done||f.value[0]==c||4!=f.value[0].x||f.value[1]!=f.value[0]?!1:e.next().done}catch(g){return!1}}())return a;
b.prototype.add=function(c){c=0===c?0:c;this.h.set(c,c);this.size=this.h.size;return this};
b.prototype["delete"]=function(c){c=this.h["delete"](c);this.size=this.h.size;return c};
b.prototype.clear=function(){this.h.clear();this.size=0};
b.prototype.has=function(c){return this.h.has(c)};
b.prototype.entries=function(){return this.h.entries()};
b.prototype.values=function(){return this.h.values()};
b.prototype.keys=b.prototype.values;b.prototype[Symbol.iterator]=b.prototype.values;b.prototype.forEach=function(c,d){var e=this;this.h.forEach(function(f){return c.call(d,f,f,e)})};
return b});
var C=this||self;function E(a,b){for(var c=a.split("."),d=b||C,e=0;e<c.length;e++)if(d=d[c[e]],null==d)return null;return d}
function ya(){}
function za(a){var b=typeof a;b="object"!=b?b:a?Array.isArray(a)?"array":b:"null";return"array"==b||"object"==b&&"number"==typeof a.length}
function F(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function Aa(a){return Object.prototype.hasOwnProperty.call(a,Ba)&&a[Ba]||(a[Ba]=++Ca)}
var Ba="closure_uid_"+(1E9*Math.random()>>>0),Ca=0;function Da(a,b,c){return a.call.apply(a.bind,arguments)}
function Ea(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,d);return a.apply(b,e)}}return function(){return a.apply(b,arguments)}}
function Fa(a,b,c){Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?Fa=Da:Fa=Ea;return Fa.apply(null,arguments)}
function H(a,b){var c=a.split("."),d=C;c[0]in d||"undefined"==typeof d.execScript||d.execScript("var "+c[0]);for(var e;c.length&&(e=c.shift());)c.length||void 0===b?d[e]&&d[e]!==Object.prototype[e]?d=d[e]:d=d[e]={}:d[e]=b}
function I(a,b){function c(){}
c.prototype=b.prototype;a.A=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.Ja=function(d,e,f){for(var g=Array(arguments.length-2),h=2;h<arguments.length;h++)g[h-2]=arguments[h];return b.prototype[e].apply(d,g)}}
function Ga(a){return a}
;function Ha(a){if(Error.captureStackTrace)Error.captureStackTrace(this,Ha);else{var b=Error().stack;b&&(this.stack=b)}a&&(this.message=String(a))}
I(Ha,Error);Ha.prototype.name="CustomError";function Ia(){var a=/[?&]dsh=1(&|$)/.test("/generate_204");this.j=!a&&/[?&]ae=1(&|$)/.test("/generate_204");this.l=!a&&/[?&]ae=2(&|$)/.test("/generate_204");if((this.h=/[?&]adurl=([^&]*)/.exec("/generate_204"))&&this.h[1]){try{var b=decodeURIComponent(this.h[1])}catch(c){b=null}this.i=b}}
;function Ja(a){var b=!1,c;return function(){b||(c=a(),b=!0);return c}}
;var Ka=Array.prototype.indexOf?function(a,b){return Array.prototype.indexOf.call(a,b,void 0)}:function(a,b){if("string"===typeof a)return"string"!==typeof b||1!=b.length?-1:a.indexOf(b,0);
for(var c=0;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},J=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e="string"===typeof a?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},La=Array.prototype.reduce?function(a,b,c){return Array.prototype.reduce.call(a,b,c)}:function(a,b,c){var d=c;
J(a,function(e,f){d=b.call(void 0,d,e,f,a)});
return d};
function Ma(a,b){a:{var c=a.length;for(var d="string"===typeof a?a.split(""):a,e=0;e<c;e++)if(e in d&&b.call(void 0,d[e],e,a)){c=e;break a}c=-1}return 0>c?null:"string"===typeof a?a.charAt(c):a[c]}
function Na(a,b){var c=Ka(a,b),d;(d=0<=c)&&Array.prototype.splice.call(a,c,1);return d}
function Oa(a){return Array.prototype.concat.apply([],arguments)}
function Pa(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function Qa(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(za(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
;function Ra(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function Sa(a){var b=Ta,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function Ua(a,b){for(var c in a)if(!(c in b)||a[c]!==b[c])return!1;for(var d in b)if(!(d in a))return!1;return!0}
function Va(a){if(!a||"object"!==typeof a)return a;if("function"===typeof a.clone)return a.clone();var b=Array.isArray(a)?[]:"function"!==typeof ArrayBuffer||"function"!==typeof ArrayBuffer.isView||!ArrayBuffer.isView(a)||a instanceof DataView?{}:new a.constructor(a.length),c;for(c in a)b[c]=Va(a[c]);return b}
var Wa="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function Xa(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<Wa.length;f++)c=Wa[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;var Ya;var Za=String.prototype.trim?function(a){return a.trim()}:function(a){return/^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]},$a=/&/g,ab=/</g,bb=/>/g,cb=/"/g,db=/'/g,eb=/\x00/g,fb=/[\x00&<>"']/;var gb;a:{var hb=C.navigator;if(hb){var ib=hb.userAgent;if(ib){gb=ib;break a}}gb=""}function K(a){return-1!=gb.indexOf(a)}
;function jb(a){this.h=kb===kb?a:""}
jb.prototype.toString=function(){return this.h.toString()};
var kb={};var lb=/^(?:([^:/?#.]+):)?(?:\/\/(?:([^\\/?#]*)@)?([^\\/?#]*?)(?::([0-9]+))?(?=[\\/?#]|$))?([^?#]+)?(?:\?([^#]*))?(?:#([\s\S]*))?$/;function mb(a){return a?decodeURI(a):a}
function nb(a){return mb(a.match(lb)[3]||null)}
function ob(a){var b=a.match(lb);a=b[1];var c=b[2],d=b[3];b=b[4];var e="";a&&(e+=a+":");d&&(e+="//",c&&(e+=c+"@"),e+=d,b&&(e+=":"+b));return e}
function pb(a,b,c){if(Array.isArray(b))for(var d=0;d<b.length;d++)pb(a,String(b[d]),c);else null!=b&&c.push(a+(""===b?"":"="+encodeURIComponent(String(b))))}
function qb(a){var b=[],c;for(c in a)pb(c,a[c],b);return b.join("&")}
var rb=/#|$/;function sb(a,b){var c=a.search(rb);a:{var d=0;for(var e=b.length;0<=(d=a.indexOf(b,d))&&d<c;){var f=a.charCodeAt(d-1);if(38==f||63==f)if(f=a.charCodeAt(d+e),!f||61==f||38==f||35==f)break a;d+=e+1}d=-1}if(0>d)return null;e=a.indexOf("&",d);if(0>e||e>c)e=c;d+=b.length+1;return decodeURIComponent(a.substr(d,e-d).replace(/\+/g," "))}
;function L(a,b){var c=void 0;return new (c||(c=Promise))(function(d,e){function f(k){try{h(b.next(k))}catch(l){e(l)}}
function g(k){try{h(b["throw"](k))}catch(l){e(l)}}
function h(k){k.done?d(k.value):(new c(function(l){l(k.value)})).then(f,g)}
h((b=b.apply(a,void 0)).next())})}
;function tb(){return K("iPhone")&&!K("iPod")&&!K("iPad")}
;function ub(a){ub[" "](a);return a}
ub[" "]=ya;var vb=K("Opera"),wb=K("Trident")||K("MSIE"),xb=K("Edge"),yb=K("Gecko")&&!(-1!=gb.toLowerCase().indexOf("webkit")&&!K("Edge"))&&!(K("Trident")||K("MSIE"))&&!K("Edge"),zb=-1!=gb.toLowerCase().indexOf("webkit")&&!K("Edge");function Ab(){var a=C.document;return a?a.documentMode:void 0}
var Bb;a:{var Cb="",Db=function(){var a=gb;if(yb)return/rv:([^\);]+)(\)|;)/.exec(a);if(xb)return/Edge\/([\d\.]+)/.exec(a);if(wb)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(zb)return/WebKit\/(\S+)/.exec(a);if(vb)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
Db&&(Cb=Db?Db[1]:"");if(wb){var Eb=Ab();if(null!=Eb&&Eb>parseFloat(Cb)){Bb=String(Eb);break a}}Bb=Cb}var Fb=Bb,Gb;if(C.document&&wb){var Hb=Ab();Gb=Hb?Hb:parseInt(Fb,10)||void 0}else Gb=void 0;var Ib=Gb;var Jb=tb()||K("iPod"),Kb=K("iPad"),Lb=K("Safari")&&!((K("Chrome")||K("CriOS"))&&!K("Edge")||K("Coast")||K("Opera")||K("Edge")||K("Edg/")||K("OPR")||K("Firefox")||K("FxiOS")||K("Silk")||K("Android"))&&!(tb()||K("iPad")||K("iPod"));var Mb={},Nb=null;var M=window;function Ob(a,b){this.width=a;this.height=b}
r=Ob.prototype;r.clone=function(){return new Ob(this.width,this.height)};
r.aspectRatio=function(){return this.width/this.height};
r.isEmpty=function(){return!(this.width*this.height)};
r.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
r.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
r.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};function Pb(){var a=document;var b="IFRAME";"application/xhtml+xml"===a.contentType&&(b=b.toLowerCase());return a.createElement(b)}
function Qb(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;function Rb(a){var b=Sb;if(b)for(var c in b)Object.prototype.hasOwnProperty.call(b,c)&&a.call(void 0,b[c],c,b)}
function Tb(){var a=[];Rb(function(b){a.push(b)});
return a}
var Sb={wa:"allow-forms",xa:"allow-modals",ya:"allow-orientation-lock",za:"allow-pointer-lock",Aa:"allow-popups",Ba:"allow-popups-to-escape-sandbox",Ca:"allow-presentation",Da:"allow-same-origin",Ea:"allow-scripts",Fa:"allow-top-navigation",Ga:"allow-top-navigation-by-user-activation"},Ub=Ja(function(){return Tb()});
function Vb(){var a=Pb(),b={};J(Ub(),function(c){a.sandbox&&a.sandbox.supports&&a.sandbox.supports(c)&&(b[c]=!0)});
return b}
;var Wb={};function Xb(a){if(a!==Wb)throw Error("Bad secret");}
;function Yb(){var a="undefined"!==typeof window?window.trustedTypes:void 0;return null!==a&&void 0!==a?a:null}
;var Zb;function $b(){}
function ac(a,b){Xb(b);this.h=a}
y(ac,$b);ac.prototype.toString=function(){return this.h.toString()};
var bc=null===(Zb=Yb())||void 0===Zb?void 0:Zb.emptyHTML;new ac(null!==bc&&void 0!==bc?bc:"",Wb);var cc;function dc(){}
function ec(a,b){Xb(b);this.h=a}
y(ec,dc);ec.prototype.toString=function(){return this.h.toString()};
var fc=null===(cc=Yb())||void 0===cc?void 0:cc.emptyScript;new ec(null!==fc&&void 0!==fc?fc:"",Wb);function gc(){}
function hc(a,b){Xb(b);this.h=a}
y(hc,gc);hc.prototype.toString=function(){return this.h};
new hc("about:blank",Wb);new hc("about:invalid#zTSz",Wb);function ic(a){var b=E("window.location.href");null==a&&(a='Unknown Error of type "null/undefined"');if("string"===typeof a)return{message:a,name:"Unknown error",lineNumber:"Not available",fileName:b,stack:"Not available"};var c=!1;try{var d=a.lineNumber||a.line||"Not available"}catch(g){d="Not available",c=!0}try{var e=a.fileName||a.filename||a.sourceURL||C.$googDebugFname||b}catch(g){e="Not available",c=!0}b=jc(a);if(!(!c&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name)){c=a.message;if(null==
c){if(a.constructor&&a.constructor instanceof Function){if(a.constructor.name)c=a.constructor.name;else if(c=a.constructor,kc[c])c=kc[c];else{c=String(c);if(!kc[c]){var f=/function\s+([^\(]+)/m.exec(c);kc[c]=f?f[1]:"[Anonymous]"}c=kc[c]}c='Unknown Error of type "'+c+'"'}else c="Unknown Error of unknown type";"function"===typeof a.toString&&Object.prototype.toString!==a.toString&&(c+=": "+a.toString())}return{message:c,name:a.name||"UnknownError",lineNumber:d,fileName:e,stack:b||"Not available"}}a.stack=
b;return a}
function jc(a,b){b||(b={});b[lc(a)]=!0;var c=a.stack||"",d=a.La;d&&!b[lc(d)]&&(c+="\nCaused by: ",d.stack&&0==d.stack.indexOf(d.toString())||(c+="string"===typeof d?d:d.message+"\n"),c+=jc(d,b));return c}
function lc(a){var b="";"function"===typeof a.toString&&(b=""+a);return b+a.stack}
var kc={};function mc(a){this.h=a||{cookie:""}}
r=mc.prototype;r.isEnabled=function(){if(!C.navigator.cookieEnabled)return!1;if(!this.isEmpty())return!0;this.set("TESTCOOKIESENABLED","1",{S:60});if("1"!==this.get("TESTCOOKIESENABLED"))return!1;this.remove("TESTCOOKIESENABLED");return!0};
r.set=function(a,b,c){var d=!1;if("object"===typeof c){var e=c.Qa;d=c.secure||!1;var f=c.domain||void 0;var g=c.path||void 0;var h=c.S}if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');void 0===h&&(h=-1);this.h.cookie=a+"="+b+(f?";domain="+f:"")+(g?";path="+g:"")+(0>h?"":0==h?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(Date.now()+1E3*h)).toUTCString())+(d?";secure":"")+(null!=e?";samesite="+e:"")};
r.get=function(a,b){for(var c=a+"=",d=(this.h.cookie||"").split(";"),e=0,f;e<d.length;e++){f=Za(d[e]);if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
r.remove=function(a,b,c){var d=void 0!==this.get(a);this.set(a,"",{S:0,path:b,domain:c});return d};
r.isEmpty=function(){return!this.h.cookie};
r.clear=function(){for(var a=(this.h.cookie||"").split(";"),b=[],c=[],d,e,f=0;f<a.length;f++)e=Za(a[f]),d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));for(a=b.length-1;0<=a;a--)this.remove(b[a])};
var nc=new mc("undefined"==typeof document?null:document);var oc=(new Date).getTime();function pc(a){if(!a)return"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));c=a.substring(0,a.indexOf("://"));if(!c)throw Error("URI is missing protocol: "+a);if("http"!==c&&"https"!==c&&"chrome-extension"!==c&&"moz-extension"!==c&&"file"!==c&&"android-app"!==c&&"chrome-search"!==c&&"chrome-untrusted"!==c&&"chrome"!==
c&&"app"!==c&&"devtools"!==c)throw Error("Invalid URI scheme in origin: "+c);a="";var d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1);b=b.substring(0,d);if("http"===c&&"80"!==e||"https"===c&&"443"!==e)a=":"+e}return c+"://"+b+a}
;function qc(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;m=l=0}
function b(n){for(var q=g,p=0;64>p;p+=4)q[p/4]=n[p]<<24|n[p+1]<<16|n[p+2]<<8|n[p+3];for(p=16;80>p;p++)n=q[p-3]^q[p-8]^q[p-14]^q[p-16],q[p]=(n<<1|n>>>31)&4294967295;n=e[0];var v=e[1],w=e[2],x=e[3],D=e[4];for(p=0;80>p;p++){if(40>p)if(20>p){var G=x^v&(w^x);var P=1518500249}else G=v^w^x,P=1859775393;else 60>p?(G=v&w|x&(v|w),P=2400959708):(G=v^w^x,P=3395469782);G=((n<<5|n>>>27)&4294967295)+G+D+P+q[p]&4294967295;D=x;x=w;w=(v<<30|v>>>2)&4294967295;v=n;n=G}e[0]=e[0]+n&4294967295;e[1]=e[1]+v&4294967295;e[2]=
e[2]+w&4294967295;e[3]=e[3]+x&4294967295;e[4]=e[4]+D&4294967295}
function c(n,q){if("string"===typeof n){n=unescape(encodeURIComponent(n));for(var p=[],v=0,w=n.length;v<w;++v)p.push(n.charCodeAt(v));n=p}q||(q=n.length);p=0;if(0==l)for(;p+64<q;)b(n.slice(p,p+64)),p+=64,m+=64;for(;p<q;)if(f[l++]=n[p++],m++,64==l)for(l=0,b(f);p+64<q;)b(n.slice(p,p+64)),p+=64,m+=64}
function d(){var n=[],q=8*m;56>l?c(h,56-l):c(h,64-(l-56));for(var p=63;56<=p;p--)f[p]=q&255,q>>>=8;b(f);for(p=q=0;5>p;p++)for(var v=24;0<=v;v-=8)n[q++]=e[p]>>v&255;return n}
for(var e=[],f=[],g=[],h=[128],k=1;64>k;++k)h[k]=0;var l,m;a();return{reset:a,update:c,digest:d,ja:function(){for(var n=d(),q="",p=0;p<n.length;p++)q+="0123456789ABCDEF".charAt(Math.floor(n[p]/16))+"0123456789ABCDEF".charAt(n[p]%16);return q}}}
;function rc(a,b,c){var d=String(C.location.href);return d&&a&&b?[b,sc(pc(d),a,c||null)].join(" "):null}
function sc(a,b,c){var d=[],e=[];if(1==(Array.isArray(c)?2:1))return e=[b,a],J(d,function(h){e.push(h)}),tc(e.join(" "));
var f=[],g=[];J(c,function(h){g.push(h.key);f.push(h.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];J(d,function(h){e.push(h)});
a=tc(e.join(" "));a=[c,a];0==g.length||a.push(g.join(""));return a.join("_")}
function tc(a){var b=qc();b.update(a);return b.ja().toLowerCase()}
;var uc={};function vc(a){return!!uc.FPA_SAMESITE_PHASE2_MOD||!(void 0===a||!a)}
function wc(a,b,c,d){(a=C[a])||(a=(new mc(document)).get(b));return a?rc(a,c,d):null}
function xc(a){var b=void 0===b?!1:b;var c=pc(String(C.location.href)),d=[];var e=b;e=void 0===e?!1:e;var f=C.__SAPISID||C.__APISID||C.__3PSAPISID||C.__OVERRIDE_SID;vc(e)&&(f=f||C.__1PSAPISID);if(f)e=!0;else{var g=new mc(document);f=g.get("SAPISID")||g.get("APISID")||g.get("__Secure-3PAPISID")||g.get("SID");vc(e)&&(f=f||g.get("__Secure-1PAPISID"));e=!!f}e&&(e=(c=0==c.indexOf("https:")||0==c.indexOf("chrome-extension:")||0==c.indexOf("moz-extension:"))?C.__SAPISID:C.__APISID,e||(e=new mc(document),
e=e.get(c?"SAPISID":"APISID")||e.get("__Secure-3PAPISID")),(e=e?rc(e,c?"SAPISIDHASH":"APISIDHASH",a):null)&&d.push(e),c&&vc(b)&&((b=wc("__1PSAPISID","__Secure-1PAPISID","SAPISID1PHASH",a))&&d.push(b),(a=wc("__3PSAPISID","__Secure-3PAPISID","SAPISID3PHASH",a))&&d.push(a)));return 0==d.length?null:d.join(" ")}
;function yc(){this.h=[];this.i=-1}
yc.prototype.set=function(a,b){b=void 0===b?!0:b;0<=a&&52>a&&0===a%1&&this.h[a]!=b&&(this.h[a]=b,this.i=-1)};
yc.prototype.get=function(a){return!!this.h[a]};
function zc(a){-1==a.i&&(a.i=La(a.h,function(b,c,d){return c?b+Math.pow(2,d):b},0));
return a.i}
;function Ac(a,b){this.j=a;this.l=b;this.i=0;this.h=null}
Ac.prototype.get=function(){if(0<this.i){this.i--;var a=this.h;this.h=a.next;a.next=null}else a=this.j();return a};
function Bc(a,b){a.l(b);100>a.i&&(a.i++,b.next=a.h,a.h=b)}
;var Cc;function Dc(){var a=C.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!K("Presto")&&(a=function(){var e=Pb();e.style.display="none";document.documentElement.appendChild(e);var f=e.contentWindow;e=f.document;e.open();e.close();var g="callImmediate"+Math.random(),h="file:"==f.location.protocol?"*":f.location.protocol+"//"+f.location.host;e=Fa(function(k){if(("*"==h||k.origin==h)&&k.data==g)this.port1.onmessage()},this);
f.addEventListener("message",e,!1);this.port1={};this.port2={postMessage:function(){f.postMessage(g,h)}}});
if("undefined"!==typeof a&&!K("Trident")&&!K("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(void 0!==c.next){c=c.next;var e=c.V;c.V=null;e()}};
return function(e){d.next={V:e};d=d.next;b.port2.postMessage(0)}}return function(e){C.setTimeout(e,0)}}
;function Ec(a){C.setTimeout(function(){throw a;},0)}
;function Fc(){this.i=this.h=null}
Fc.prototype.add=function(a,b){var c=Gc.get();c.set(a,b);this.i?this.i.next=c:this.h=c;this.i=c};
Fc.prototype.remove=function(){var a=null;this.h&&(a=this.h,this.h=this.h.next,this.h||(this.i=null),a.next=null);return a};
var Gc=new Ac(function(){return new Hc},function(a){return a.reset()});
function Hc(){this.next=this.scope=this.h=null}
Hc.prototype.set=function(a,b){this.h=a;this.scope=b;this.next=null};
Hc.prototype.reset=function(){this.next=this.scope=this.h=null};function Ic(a,b){Jc||Kc();Lc||(Jc(),Lc=!0);Mc.add(a,b)}
var Jc;function Kc(){if(C.Promise&&C.Promise.resolve){var a=C.Promise.resolve(void 0);Jc=function(){a.then(Nc)}}else Jc=function(){var b=Nc;
"function"!==typeof C.setImmediate||C.Window&&C.Window.prototype&&!K("Edge")&&C.Window.prototype.setImmediate==C.setImmediate?(Cc||(Cc=Dc()),Cc(b)):C.setImmediate(b)}}
var Lc=!1,Mc=new Fc;function Nc(){for(var a;a=Mc.remove();){try{a.h.call(a.scope)}catch(b){Ec(b)}Bc(Gc,a)}Lc=!1}
;function Oc(){this.i=-1}
;function Pc(){this.i=64;this.h=[];this.o=[];this.s=[];this.l=[];this.l[0]=128;for(var a=1;a<this.i;++a)this.l[a]=0;this.m=this.j=0;this.reset()}
I(Pc,Oc);Pc.prototype.reset=function(){this.h[0]=1732584193;this.h[1]=4023233417;this.h[2]=2562383102;this.h[3]=271733878;this.h[4]=3285377520;this.m=this.j=0};
function Qc(a,b,c){c||(c=0);var d=a.s;if("string"===typeof b)for(var e=0;16>e;e++)d[e]=b.charCodeAt(c)<<24|b.charCodeAt(c+1)<<16|b.charCodeAt(c+2)<<8|b.charCodeAt(c+3),c+=4;else for(e=0;16>e;e++)d[e]=b[c]<<24|b[c+1]<<16|b[c+2]<<8|b[c+3],c+=4;for(e=16;80>e;e++){var f=d[e-3]^d[e-8]^d[e-14]^d[e-16];d[e]=(f<<1|f>>>31)&4294967295}b=a.h[0];c=a.h[1];var g=a.h[2],h=a.h[3],k=a.h[4];for(e=0;80>e;e++){if(40>e)if(20>e){f=h^c&(g^h);var l=1518500249}else f=c^g^h,l=1859775393;else 60>e?(f=c&g|h&(c|g),l=2400959708):
(f=c^g^h,l=3395469782);f=(b<<5|b>>>27)+f+k+l+d[e]&4294967295;k=h;h=g;g=(c<<30|c>>>2)&4294967295;c=b;b=f}a.h[0]=a.h[0]+b&4294967295;a.h[1]=a.h[1]+c&4294967295;a.h[2]=a.h[2]+g&4294967295;a.h[3]=a.h[3]+h&4294967295;a.h[4]=a.h[4]+k&4294967295}
Pc.prototype.update=function(a,b){if(null!=a){void 0===b&&(b=a.length);for(var c=b-this.i,d=0,e=this.o,f=this.j;d<b;){if(0==f)for(;d<=c;)Qc(this,a,d),d+=this.i;if("string"===typeof a)for(;d<b;){if(e[f]=a.charCodeAt(d),++f,++d,f==this.i){Qc(this,e);f=0;break}}else for(;d<b;)if(e[f]=a[d],++f,++d,f==this.i){Qc(this,e);f=0;break}}this.j=f;this.m+=b}};
Pc.prototype.digest=function(){var a=[],b=8*this.m;56>this.j?this.update(this.l,56-this.j):this.update(this.l,this.i-(this.j-56));for(var c=this.i-1;56<=c;c--)this.o[c]=b&255,b/=256;Qc(this,this.o);for(c=b=0;5>c;c++)for(var d=24;0<=d;d-=8)a[b]=this.h[c]>>d&255,++b;return a};function Rc(){this.j=this.j;this.m=this.m}
Rc.prototype.j=!1;Rc.prototype.dispose=function(){this.j||(this.j=!0,this.K())};
Rc.prototype.K=function(){if(this.m)for(;this.m.length;)this.m.shift()()};var Sc="StopIteration"in C?C.StopIteration:{message:"StopIteration",stack:""};function Tc(){}
Tc.prototype.next=function(){throw Sc;};
Tc.prototype.F=function(){return this};
function Uc(a){if(a instanceof Tc)return a;if("function"==typeof a.F)return a.F(!1);if(za(a)){var b=0,c=new Tc;c.next=function(){for(;;){if(b>=a.length)throw Sc;if(b in a)return a[b++];b++}};
return c}throw Error("Not implemented");}
function Vc(a,b){if(za(a))try{J(a,b,void 0)}catch(c){if(c!==Sc)throw c;}else{a=Uc(a);try{for(;;)b.call(void 0,a.next(),void 0,a)}catch(c){if(c!==Sc)throw c;}}}
function Wc(a){if(za(a))return Pa(a);a=Uc(a);var b=[];Vc(a,function(c){b.push(c)});
return b}
;function Xc(a,b){this.i={};this.h=[];this.l=this.j=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a)if(a instanceof Xc)for(c=Yc(a),d=0;d<c.length;d++)this.set(c[d],a.get(c[d]));else for(d in a)this.set(d,a[d])}
function Yc(a){Zc(a);return a.h.concat()}
r=Xc.prototype;r.equals=function(a,b){if(this===a)return!0;if(this.j!=a.j)return!1;var c=b||$c;Zc(this);for(var d,e=0;d=this.h[e];e++)if(!c(this.get(d),a.get(d)))return!1;return!0};
function $c(a,b){return a===b}
r.isEmpty=function(){return 0==this.j};
r.clear=function(){this.i={};this.l=this.j=this.h.length=0};
r.remove=function(a){return Object.prototype.hasOwnProperty.call(this.i,a)?(delete this.i[a],this.j--,this.l++,this.h.length>2*this.j&&Zc(this),!0):!1};
function Zc(a){if(a.j!=a.h.length){for(var b=0,c=0;b<a.h.length;){var d=a.h[b];Object.prototype.hasOwnProperty.call(a.i,d)&&(a.h[c++]=d);b++}a.h.length=c}if(a.j!=a.h.length){var e={};for(c=b=0;b<a.h.length;)d=a.h[b],Object.prototype.hasOwnProperty.call(e,d)||(a.h[c++]=d,e[d]=1),b++;a.h.length=c}}
r.get=function(a,b){return Object.prototype.hasOwnProperty.call(this.i,a)?this.i[a]:b};
r.set=function(a,b){Object.prototype.hasOwnProperty.call(this.i,a)||(this.j++,this.h.push(a),this.l++);this.i[a]=b};
r.forEach=function(a,b){for(var c=Yc(this),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
r.clone=function(){return new Xc(this)};
r.F=function(a){Zc(this);var b=0,c=this.l,d=this,e=new Tc;e.next=function(){if(c!=d.l)throw Error("The map has changed since the iterator was created");if(b>=d.h.length)throw Sc;var f=d.h[b++];return a?f:d.i[f]};
return e};var ad=function(){if(!C.addEventListener||!Object.defineProperty)return!1;var a=!1,b=Object.defineProperty({},"passive",{get:function(){a=!0}});
try{C.addEventListener("test",ya,b),C.removeEventListener("test",ya,b)}catch(c){}return a}();function bd(a,b){this.type=a;this.h=this.target=b;this.defaultPrevented=this.j=!1}
bd.prototype.stopPropagation=function(){this.j=!0};
bd.prototype.preventDefault=function(){this.defaultPrevented=!0};function cd(a,b){bd.call(this,a?a.type:"");this.relatedTarget=this.h=this.target=null;this.button=this.screenY=this.screenX=this.clientY=this.clientX=0;this.key="";this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.altKey=this.ctrlKey=!1;this.state=null;this.pointerId=0;this.pointerType="";this.i=null;a&&this.init(a,b)}
I(cd,bd);var dd={2:"touch",3:"pen",4:"mouse"};
cd.prototype.init=function(a,b){var c=this.type=a.type,d=a.changedTouches&&a.changedTouches.length?a.changedTouches[0]:null;this.target=a.target||a.srcElement;this.h=b;var e=a.relatedTarget;if(e){if(yb){a:{try{ub(e.nodeName);var f=!0;break a}catch(g){}f=!1}f||(e=null)}}else"mouseover"==c?e=a.fromElement:"mouseout"==c&&(e=a.toElement);this.relatedTarget=e;d?(this.clientX=void 0!==d.clientX?d.clientX:d.pageX,this.clientY=void 0!==d.clientY?d.clientY:d.pageY,this.screenX=d.screenX||0,this.screenY=d.screenY||
0):(this.clientX=void 0!==a.clientX?a.clientX:a.pageX,this.clientY=void 0!==a.clientY?a.clientY:a.pageY,this.screenX=a.screenX||0,this.screenY=a.screenY||0);this.button=a.button;this.keyCode=a.keyCode||0;this.key=a.key||"";this.charCode=a.charCode||("keypress"==c?a.keyCode:0);this.ctrlKey=a.ctrlKey;this.altKey=a.altKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey;this.pointerId=a.pointerId||0;this.pointerType="string"===typeof a.pointerType?a.pointerType:dd[a.pointerType]||"";this.state=a.state;
this.i=a;a.defaultPrevented&&cd.A.preventDefault.call(this)};
cd.prototype.stopPropagation=function(){cd.A.stopPropagation.call(this);this.i.stopPropagation?this.i.stopPropagation():this.i.cancelBubble=!0};
cd.prototype.preventDefault=function(){cd.A.preventDefault.call(this);var a=this.i;a.preventDefault?a.preventDefault():a.returnValue=!1};var ed="closure_listenable_"+(1E6*Math.random()|0);var fd=0;function gd(a,b,c,d,e){this.listener=a;this.h=null;this.src=b;this.type=c;this.capture=!!d;this.P=e;this.key=++fd;this.L=this.N=!1}
function hd(a){a.L=!0;a.listener=null;a.h=null;a.src=null;a.P=null}
;function id(a){this.src=a;this.listeners={};this.h=0}
id.prototype.add=function(a,b,c,d,e){var f=a.toString();a=this.listeners[f];a||(a=this.listeners[f]=[],this.h++);var g=jd(a,b,d,e);-1<g?(b=a[g],c||(b.N=!1)):(b=new gd(b,this.src,f,!!d,e),b.N=c,a.push(b));return b};
id.prototype.remove=function(a,b,c,d){a=a.toString();if(!(a in this.listeners))return!1;var e=this.listeners[a];b=jd(e,b,c,d);return-1<b?(hd(e[b]),Array.prototype.splice.call(e,b,1),0==e.length&&(delete this.listeners[a],this.h--),!0):!1};
function kd(a,b){var c=b.type;c in a.listeners&&Na(a.listeners[c],b)&&(hd(b),0==a.listeners[c].length&&(delete a.listeners[c],a.h--))}
function jd(a,b,c,d){for(var e=0;e<a.length;++e){var f=a[e];if(!f.L&&f.listener==b&&f.capture==!!c&&f.P==d)return e}return-1}
;var ld="closure_lm_"+(1E6*Math.random()|0),md={},nd=0;function od(a,b,c,d,e){if(d&&d.once)pd(a,b,c,d,e);else if(Array.isArray(b))for(var f=0;f<b.length;f++)od(a,b[f],c,d,e);else c=qd(c),a&&a[ed]?rd(a,b,c,F(d)?!!d.capture:!!d,e):sd(a,b,c,!1,d,e)}
function sd(a,b,c,d,e,f){if(!b)throw Error("Invalid event type");var g=F(e)?!!e.capture:!!e,h=td(a);h||(a[ld]=h=new id(a));c=h.add(b,c,d,g,f);if(!c.h){d=ud();c.h=d;d.src=a;d.listener=c;if(a.addEventListener)ad||(e=g),void 0===e&&(e=!1),a.addEventListener(b.toString(),d,e);else if(a.attachEvent)a.attachEvent(vd(b.toString()),d);else if(a.addListener&&a.removeListener)a.addListener(d);else throw Error("addEventListener and attachEvent are unavailable.");nd++}}
function ud(){function a(c){return b.call(a.src,a.listener,c)}
var b=wd;return a}
function pd(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)pd(a,b[f],c,d,e);else c=qd(c),a&&a[ed]?a.h.add(String(b),c,!0,F(d)?!!d.capture:!!d,e):sd(a,b,c,!0,d,e)}
function xd(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)xd(a,b[f],c,d,e);else(d=F(d)?!!d.capture:!!d,c=qd(c),a&&a[ed])?a.h.remove(String(b),c,d,e):a&&(a=td(a))&&(b=a.listeners[b.toString()],a=-1,b&&(a=jd(b,c,d,e)),(c=-1<a?b[a]:null)&&yd(c))}
function yd(a){if("number"!==typeof a&&a&&!a.L){var b=a.src;if(b&&b[ed])kd(b.h,a);else{var c=a.type,d=a.h;b.removeEventListener?b.removeEventListener(c,d,a.capture):b.detachEvent?b.detachEvent(vd(c),d):b.addListener&&b.removeListener&&b.removeListener(d);nd--;(c=td(b))?(kd(c,a),0==c.h&&(c.src=null,b[ld]=null)):hd(a)}}}
function vd(a){return a in md?md[a]:md[a]="on"+a}
function wd(a,b){if(a.L)var c=!0;else{c=new cd(b,this);var d=a.listener,e=a.P||a.src;a.N&&yd(a);c=d.call(e,c)}return c}
function td(a){a=a[ld];return a instanceof id?a:null}
var zd="__closure_events_fn_"+(1E9*Math.random()>>>0);function qd(a){if("function"===typeof a)return a;a[zd]||(a[zd]=function(b){return a.handleEvent(b)});
return a[zd]}
;function N(){Rc.call(this);this.h=new id(this);this.D=this;this.o=null}
I(N,Rc);N.prototype[ed]=!0;N.prototype.addEventListener=function(a,b,c,d){od(this,a,b,c,d)};
N.prototype.removeEventListener=function(a,b,c,d){xd(this,a,b,c,d)};
function Ad(a,b){var c=a.o;if(c){var d=[];for(var e=1;c;c=c.o)d.push(c),++e}c=a.D;e=b;var f=e.type||e;if("string"===typeof e)e=new bd(e,c);else if(e instanceof bd)e.target=e.target||c;else{var g=e;e=new bd(f,c);Xa(e,g)}g=!0;if(d)for(var h=d.length-1;!e.j&&0<=h;h--){var k=e.h=d[h];g=Bd(k,f,!0,e)&&g}e.j||(k=e.h=c,g=Bd(k,f,!0,e)&&g,e.j||(g=Bd(k,f,!1,e)&&g));if(d)for(h=0;!e.j&&h<d.length;h++)k=e.h=d[h],g=Bd(k,f,!1,e)&&g}
N.prototype.K=function(){N.A.K.call(this);if(this.h){var a=this.h,b=0,c;for(c in a.listeners){for(var d=a.listeners[c],e=0;e<d.length;e++)++b,hd(d[e]);delete a.listeners[c];a.h--}}this.o=null};
function rd(a,b,c,d,e){a.h.add(String(b),c,!1,d,e)}
function Bd(a,b,c,d){b=a.h.listeners[String(b)];if(!b)return!0;b=b.concat();for(var e=!0,f=0;f<b.length;++f){var g=b[f];if(g&&!g.L&&g.capture==c){var h=g.listener,k=g.P||g.src;g.N&&kd(a.h,g);e=!1!==h.call(k,d)&&e}}return e&&!d.defaultPrevented}
;var Cd=C.JSON.stringify;function O(a){this.h=0;this.s=void 0;this.l=this.i=this.j=null;this.m=this.o=!1;if(a!=ya)try{var b=this;a.call(void 0,function(c){Dd(b,2,c)},function(c){Dd(b,3,c)})}catch(c){Dd(this,3,c)}}
function Ed(){this.next=this.context=this.onRejected=this.i=this.h=null;this.j=!1}
Ed.prototype.reset=function(){this.context=this.onRejected=this.i=this.h=null;this.j=!1};
var Fd=new Ac(function(){return new Ed},function(a){a.reset()});
function Gd(a,b,c){var d=Fd.get();d.i=a;d.onRejected=b;d.context=c;return d}
O.prototype.then=function(a,b,c){return Hd(this,"function"===typeof a?a:null,"function"===typeof b?b:null,c)};
O.prototype.$goog_Thenable=!0;O.prototype.cancel=function(a){if(0==this.h){var b=new Id(a);Ic(function(){Jd(this,b)},this)}};
function Jd(a,b){if(0==a.h)if(a.j){var c=a.j;if(c.i){for(var d=0,e=null,f=null,g=c.i;g&&(g.j||(d++,g.h==a&&(e=g),!(e&&1<d)));g=g.next)e||(f=g);e&&(0==c.h&&1==d?Jd(c,b):(f?(d=f,d.next==c.l&&(c.l=d),d.next=d.next.next):Kd(c),Ld(c,e,3,b)))}a.j=null}else Dd(a,3,b)}
function Md(a,b){a.i||2!=a.h&&3!=a.h||Nd(a);a.l?a.l.next=b:a.i=b;a.l=b}
function Hd(a,b,c,d){var e=Gd(null,null,null);e.h=new O(function(f,g){e.i=b?function(h){try{var k=b.call(d,h);f(k)}catch(l){g(l)}}:f;
e.onRejected=c?function(h){try{var k=c.call(d,h);void 0===k&&h instanceof Id?g(h):f(k)}catch(l){g(l)}}:g});
e.h.j=a;Md(a,e);return e.h}
O.prototype.C=function(a){this.h=0;Dd(this,2,a)};
O.prototype.D=function(a){this.h=0;Dd(this,3,a)};
function Dd(a,b,c){if(0==a.h){a===c&&(b=3,c=new TypeError("Promise cannot resolve to itself"));a.h=1;a:{var d=c,e=a.C,f=a.D;if(d instanceof O){Md(d,Gd(e||ya,f||null,a));var g=!0}else{if(d)try{var h=!!d.$goog_Thenable}catch(l){h=!1}else h=!1;if(h)d.then(e,f,a),g=!0;else{if(F(d))try{var k=d.then;if("function"===typeof k){Od(d,k,e,f,a);g=!0;break a}}catch(l){f.call(a,l);g=!0;break a}g=!1}}}g||(a.s=c,a.h=b,a.j=null,Nd(a),3!=b||c instanceof Id||Pd(a,c))}}
function Od(a,b,c,d,e){function f(k){h||(h=!0,d.call(e,k))}
function g(k){h||(h=!0,c.call(e,k))}
var h=!1;try{b.call(a,g,f)}catch(k){f(k)}}
function Nd(a){a.o||(a.o=!0,Ic(a.u,a))}
function Kd(a){var b=null;a.i&&(b=a.i,a.i=b.next,b.next=null);a.i||(a.l=null);return b}
O.prototype.u=function(){for(var a;a=Kd(this);)Ld(this,a,this.h,this.s);this.o=!1};
function Ld(a,b,c,d){if(3==c&&b.onRejected&&!b.j)for(;a&&a.m;a=a.j)a.m=!1;if(b.h)b.h.j=null,Qd(b,c,d);else try{b.j?b.i.call(b.context):Qd(b,c,d)}catch(e){Rd.call(null,e)}Bc(Fd,b)}
function Qd(a,b,c){2==b?a.i.call(a.context,c):a.onRejected&&a.onRejected.call(a.context,c)}
function Pd(a,b){a.m=!0;Ic(function(){a.m&&Rd.call(null,b)})}
var Rd=Ec;function Id(a){Ha.call(this,a)}
I(Id,Ha);Id.prototype.name="cancel";function Q(a){Rc.call(this);this.s=1;this.l=[];this.o=0;this.h=[];this.i={};this.u=!!a}
I(Q,Rc);r=Q.prototype;r.subscribe=function(a,b,c){var d=this.i[a];d||(d=this.i[a]=[]);var e=this.s;this.h[e]=a;this.h[e+1]=b;this.h[e+2]=c;this.s=e+3;d.push(e);return e};
function Sd(a,b,c){var d=Td;if(a=d.i[a]){var e=d.h;(a=Ma(a,function(f){return e[f+1]==b&&e[f+2]==c}))&&d.M(a)}}
r.M=function(a){var b=this.h[a];if(b){var c=this.i[b];0!=this.o?(this.l.push(a),this.h[a+1]=ya):(c&&Na(c,a),delete this.h[a],delete this.h[a+1],delete this.h[a+2])}return!!b};
r.J=function(a,b){var c=this.i[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.u)for(e=0;e<c.length;e++){var g=c[e];Ud(this.h[g+1],this.h[g+2],d)}else{this.o++;try{for(e=0,f=c.length;e<f;e++)g=c[e],this.h[g+1].apply(this.h[g+2],d)}finally{if(this.o--,0<this.l.length&&0==this.o)for(;c=this.l.pop();)this.M(c)}}return 0!=e}return!1};
function Ud(a,b,c){Ic(function(){a.apply(b,c)})}
r.clear=function(a){if(a){var b=this.i[a];b&&(J(b,this.M,this),delete this.i[a])}else this.h.length=0,this.i={}};
r.K=function(){Q.A.K.call(this);this.clear();this.l.length=0};function Vd(a){this.h=a}
Vd.prototype.set=function(a,b){void 0===b?this.h.remove(a):this.h.set(a,Cd(b))};
Vd.prototype.get=function(a){try{var b=this.h.get(a)}catch(c){return}if(null!==b)try{return JSON.parse(b)}catch(c){throw"Storage: Invalid value was encountered";}};
Vd.prototype.remove=function(a){this.h.remove(a)};function Wd(a){this.h=a}
I(Wd,Vd);function Xd(a){this.data=a}
function Yd(a){return void 0===a||a instanceof Xd?a:new Xd(a)}
Wd.prototype.set=function(a,b){Wd.A.set.call(this,a,Yd(b))};
Wd.prototype.i=function(a){a=Wd.A.get.call(this,a);if(void 0===a||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
Wd.prototype.get=function(a){if(a=this.i(a)){if(a=a.data,void 0===a)throw"Storage: Invalid value was encountered";}else a=void 0;return a};function Zd(a){this.h=a}
I(Zd,Wd);Zd.prototype.set=function(a,b,c){if(b=Yd(b)){if(c){if(c<Date.now()){Zd.prototype.remove.call(this,a);return}b.expiration=c}b.creation=Date.now()}Zd.A.set.call(this,a,b)};
Zd.prototype.i=function(a){var b=Zd.A.i.call(this,a);if(b){var c=b.creation,d=b.expiration;if(d&&d<Date.now()||c&&c>Date.now())Zd.prototype.remove.call(this,a);else return b}};function $d(){}
;function ae(){}
I(ae,$d);ae.prototype.clear=function(){var a=Wc(this.F(!0)),b=this;J(a,function(c){b.remove(c)})};function be(a){this.h=a}
I(be,ae);r=be.prototype;r.isAvailable=function(){if(!this.h)return!1;try{return this.h.setItem("__sak","1"),this.h.removeItem("__sak"),!0}catch(a){return!1}};
r.set=function(a,b){try{this.h.setItem(a,b)}catch(c){if(0==this.h.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
r.get=function(a){a=this.h.getItem(a);if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
r.remove=function(a){this.h.removeItem(a)};
r.F=function(a){var b=0,c=this.h,d=new Tc;d.next=function(){if(b>=c.length)throw Sc;var e=c.key(b++);if(a)return e;e=c.getItem(e);if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
r.clear=function(){this.h.clear()};
r.key=function(a){return this.h.key(a)};function ce(){var a=null;try{a=window.localStorage||null}catch(b){}this.h=a}
I(ce,be);function de(a,b){this.i=a;this.h=null;if(wb&&!(9<=Number(Ib))){ee||(ee=new Xc);this.h=ee.get(a);this.h||(b?this.h=document.getElementById(b):(this.h=document.createElement("userdata"),this.h.addBehavior("#default#userData"),document.body.appendChild(this.h)),ee.set(a,this.h));try{this.h.load(this.i)}catch(c){this.h=null}}}
I(de,ae);var fe={".":".2E","!":".21","~":".7E","*":".2A","'":".27","(":".28",")":".29","%":"."},ee=null;function ge(a){return"_"+encodeURIComponent(a).replace(/[.!~*'()%]/g,function(b){return fe[b]})}
r=de.prototype;r.isAvailable=function(){return!!this.h};
r.set=function(a,b){this.h.setAttribute(ge(a),b);he(this)};
r.get=function(a){a=this.h.getAttribute(ge(a));if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
r.remove=function(a){this.h.removeAttribute(ge(a));he(this)};
r.F=function(a){var b=0,c=this.h.XMLDocument.documentElement.attributes,d=new Tc;d.next=function(){if(b>=c.length)throw Sc;var e=c[b++];if(a)return decodeURIComponent(e.nodeName.replace(/\./g,"%")).substr(1);e=e.nodeValue;if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
r.clear=function(){for(var a=this.h.XMLDocument.documentElement,b=a.attributes.length;0<b;b--)a.removeAttribute(a.attributes[b-1].nodeName);he(this)};
function he(a){try{a.h.save(a.i)}catch(b){throw"Storage mechanism: Quota exceeded";}}
;function ie(a,b){this.i=a;this.h=b+"::"}
I(ie,ae);ie.prototype.set=function(a,b){this.i.set(this.h+a,b)};
ie.prototype.get=function(a){return this.i.get(this.h+a)};
ie.prototype.remove=function(a){this.i.remove(this.h+a)};
ie.prototype.F=function(a){var b=this.i.F(!0),c=this,d=new Tc;d.next=function(){for(var e=b.next();e.substr(0,c.h.length)!=c.h;)e=b.next();return a?e.substr(c.h.length):c.i.get(e)};
return d};var je=window.yt&&window.yt.config_||window.ytcfg&&window.ytcfg.data_||{};H("yt.config_",je);function ke(a){var b=arguments;1<b.length?je[b[0]]=b[1]:1===b.length&&Object.assign(je,b[0])}
function R(a,b){return a in je?je[a]:b}
;var le=[];function me(a){le.forEach(function(b){return b(a)})}
function ne(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){oe(b),me(b)}}:a}
function oe(a){var b=E("yt.logging.errors.log");b?b(a,"ERROR",void 0,void 0,void 0):(b=R("ERRORS",[]),b.push([a,"ERROR",void 0,void 0,void 0]),ke("ERRORS",b))}
function pe(a){var b=E("yt.logging.errors.log");b?b(a,"WARNING",void 0,void 0,void 0):(b=R("ERRORS",[]),b.push([a,"WARNING",void 0,void 0,void 0]),ke("ERRORS",b))}
;var qe=0;H("ytDomDomGetNextId",E("ytDomDomGetNextId")||function(){return++qe});var re={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};
function se(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.ctrlKey=this.altKey=!1;this.clientY=this.clientX=0;this.changedTouches=this.touches=null;try{if(a=a||window.event){this.event=a;for(var b in a)b in re||(this[b]=a[b]);var c=a.target||a.srcElement;c&&3==c.nodeType&&(c=c.parentNode);this.target=c;var d=a.relatedTarget;if(d)try{d=d.nodeName?d:null}catch(e){d=null}else"mouseover"==
this.type?d=a.fromElement:"mouseout"==this.type&&(d=a.toElement);this.relatedTarget=d;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey}}catch(e){}}
se.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
se.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
se.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};var Ta=C.ytEventsEventsListeners||{};H("ytEventsEventsListeners",Ta);var te=C.ytEventsEventsCounter||{count:0};H("ytEventsEventsCounter",te);
function ue(a,b,c,d){d=void 0===d?{}:d;a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return Sa(function(e){var f="boolean"===typeof e[4]&&e[4]==!!d,g=F(e[4])&&F(d)&&Ua(e[4],d);return!!e.length&&e[0]==a&&e[1]==b&&e[2]==c&&(f||g)})}
function ve(a){a&&("string"==typeof a&&(a=[a]),J(a,function(b){if(b in Ta){var c=Ta[b],d=c[0],e=c[1],f=c[3];c=c[4];d.removeEventListener?we()||"boolean"===typeof c?d.removeEventListener(e,f,c):d.removeEventListener(e,f,!!c.capture):d.detachEvent&&d.detachEvent("on"+e,f);delete Ta[b]}}))}
var we=Ja(function(){var a=!1;try{var b=Object.defineProperty({},"capture",{get:function(){a=!0}});
window.addEventListener("test",null,b)}catch(c){}return a});
function xe(a,b,c){var d=void 0===d?{}:d;if(a&&(a.addEventListener||a.attachEvent)){var e=ue(a,b,c,d);if(!e){e=++te.count+"";var f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document);var g=f?function(h){h=new se(h);if(!Qb(h.relatedTarget,function(k){return k==a}))return h.currentTarget=a,h.type=b,c.call(a,h)}:function(h){h=new se(h);
h.currentTarget=a;return c.call(a,h)};
g=ne(g);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),we()||"boolean"===typeof d?a.addEventListener(b,g,d):a.addEventListener(b,g,!!d.capture)):a.attachEvent("on"+b,g);Ta[e]=[a,b,c,g,d]}}}
;function ye(a,b){"function"===typeof a&&(a=ne(a));return window.setTimeout(a,b)}
function ze(a){"function"===typeof a&&(a=ne(a));return window.setInterval(a,250)}
;var Ae=/^[\w.]*$/,Be={q:!0,search_query:!0};function Ce(a,b){for(var c=a.split(b),d={},e=0,f=c.length;e<f;e++){var g=c[e].split("=");if(1==g.length&&g[0]||2==g.length)try{var h=De(g[0]||""),k=De(g[1]||"");h in d?Array.isArray(d[h])?Qa(d[h],k):d[h]=[d[h],k]:d[h]=k}catch(q){var l=q,m=g[0],n=String(Ce);l.args=[{key:m,value:g[1],query:a,method:Ee==n?"unchanged":n}];Be.hasOwnProperty(m)||pe(l)}}return d}
var Ee=String(Ce);function Fe(a){var b=[];Ra(a,function(c,d){var e=encodeURIComponent(String(d)),f;Array.isArray(c)?f=c:f=[c];J(f,function(g){""==g?b.push(e):b.push(e+"="+encodeURIComponent(String(g)))})});
return b.join("&")}
function Ge(a){"?"==a.charAt(0)&&(a=a.substr(1));return Ce(a,"&")}
function He(a,b,c){var d=a.split("#",2);a=d[0];d=1<d.length?"#"+d[1]:"";var e=a.split("?",2);a=e[0];e=Ge(e[1]||"");for(var f in b)!c&&null!==e&&f in e||(e[f]=b[f]);b=a;a=qb(e);a?(c=b.indexOf("#"),0>c&&(c=b.length),f=b.indexOf("?"),0>f||f>c?(f=c,e=""):e=b.substring(f+1,c),b=[b.substr(0,f),e,b.substr(c)],c=b[1],b[1]=a?c?c+"&"+a:a:c,a=b[0]+(b[1]?"?"+b[1]:"")+b[2]):a=b;return a+d}
function De(a){return a&&a.match(Ae)?a:decodeURIComponent(a.replace(/\+/g," "))}
;var Ie={};function Je(a){return Ie[a]||(Ie[a]=String(a).replace(/\-([a-z])/g,function(b,c){return c.toUpperCase()}))}
;var Ke={},Le=[],Td=new Q,Me={};function Ne(){for(var a=u(Le),b=a.next();!b.done;b=a.next())b=b.value,b()}
function Oe(a,b){var c;"yt:"==a.tagName.toLowerCase().substr(0,3)?c=a.getAttribute(b):c=a?a.dataset?a.dataset[Je(b)]:a.getAttribute("data-"+b):null;return c}
function Pe(a,b){Td.J.apply(Td,arguments)}
;function Qe(a){this.i=a||{};this.j=this.h=!1;a=document.getElementById("www-widgetapi-script");if(this.h=!!("https:"==document.location.protocol||a&&0==a.src.indexOf("https:"))){a=[this.i,window.YTConfig||{}];for(var b=0;b<a.length;b++)a[b].host&&(a[b].host=a[b].host.replace("http://","https://"))}}
function S(a,b){for(var c=[a.i,window.YTConfig||{}],d=0;d<c.length;d++){var e=c[d][b];if(void 0!=e)return e}return null}
function Re(a,b,c){Se||(Se={},xe(window,"message",Fa(a.l,a)));Se[c]=b}
Qe.prototype.l=function(a){if(a.origin==S(this,"host")||a.origin==S(this,"host").replace(/^http:/,"https:")){try{var b=JSON.parse(a.data)}catch(c){return}this.j=!0;this.h||0!=a.origin.indexOf("https:")||(this.h=!0);if(a=Se[b.id])a.u=!0,a.u&&(J(a.s,a.U,a),a.s.length=0),a.ba(b)}};
var Se=null;function T(a){a=Te(a);return"string"===typeof a&&"false"===a?!1:!!a}
function Ue(a,b){var c=Te(a);return void 0===c&&void 0!==b?b:Number(c||0)}
function Te(a){var b=R("EXPERIMENTS_FORCED_FLAGS",{});return void 0!==b[a]?b[a]:R("EXPERIMENT_FLAGS",{})[a]}
;function Ve(){}
function We(a,b){return Xe(a,1,b)}
;function Ye(){Ve.apply(this,arguments)}
y(Ye,Ve);function Xe(a,b,c){void 0!==c&&Number.isNaN(Number(c))&&(c=void 0);var d=E("yt.scheduler.instance.addJob");return d?d(a,b,c):void 0===c?(a(),NaN):ye(a,c||0)}
function Ze(a){if(void 0===a||!Number.isNaN(Number(a))){var b=E("yt.scheduler.instance.cancelJob");b?b(a):window.clearTimeout(a)}}
Ye.prototype.start=function(){var a=E("yt.scheduler.instance.start");a&&a()};
Ye.h=void 0;Ye.i=function(){Ye.h||(Ye.h=new Ye)};
Ye.i();function $e(a){var b=af;a=void 0===a?E("yt.ads.biscotti.lastId_")||"":a;var c=Object,d=c.assign,e={};e.dt=oc;e.flash="0";a:{try{var f=b.h.top.location.href}catch(D){f=2;break a}f=f?f===b.i.location.href?0:1:2}e=(e.frm=f,e);e.u_tz=-(new Date).getTimezoneOffset();var g=void 0===g?M:g;try{var h=g.history.length}catch(D){h=0}e.u_his=h;e.u_java=!!M.navigator&&"unknown"!==typeof M.navigator.javaEnabled&&!!M.navigator.javaEnabled&&M.navigator.javaEnabled();M.screen&&(e.u_h=M.screen.height,e.u_w=M.screen.width,
e.u_ah=M.screen.availHeight,e.u_aw=M.screen.availWidth,e.u_cd=M.screen.colorDepth);M.navigator&&M.navigator.plugins&&(e.u_nplug=M.navigator.plugins.length);M.navigator&&M.navigator.mimeTypes&&(e.u_nmime=M.navigator.mimeTypes.length);h=b.h;try{var k=h.screenX;var l=h.screenY}catch(D){}try{var m=h.outerWidth;var n=h.outerHeight}catch(D){}try{var q=h.innerWidth;var p=h.innerHeight}catch(D){}k=[h.screenLeft,h.screenTop,k,l,h.screen?h.screen.availWidth:void 0,h.screen?h.screen.availTop:void 0,m,n,q,p];
l=b.h.top;try{var v=(l||window).document,w="CSS1Compat"==v.compatMode?v.documentElement:v.body;var x=(new Ob(w.clientWidth,w.clientHeight)).round()}catch(D){x=new Ob(-12245933,-12245933)}v=x;x={};w=new yc;C.SVGElement&&C.document.createElementNS&&w.set(0);l=Vb();l["allow-top-navigation-by-user-activation"]&&w.set(1);l["allow-popups-to-escape-sandbox"]&&w.set(2);C.crypto&&C.crypto.subtle&&w.set(3);C.TextDecoder&&C.TextEncoder&&w.set(4);w=zc(w);x.bc=w;x.bih=v.height;x.biw=v.width;x.brdim=k.join();b=
b.i;b=(x.vis={visible:1,hidden:2,prerender:3,preview:4,unloaded:5}[b.visibilityState||b.webkitVisibilityState||b.mozVisibilityState||""]||0,x.wgl=!!M.WebGLRenderingContext,x);c=d.call(c,e,b);c.ca_type="image";a&&(c.bid=a);return c}
var af=new function(){var a=window.document;this.h=window;this.i=a};
H("yt.ads_.signals_.getAdSignalsString",function(a){return Fe($e(a))});var bf="XMLHttpRequest"in C?function(){return new XMLHttpRequest}:null;
function cf(){if(!bf)return null;var a=bf();return"open"in a?a:null}
;var df={Authorization:"AUTHORIZATION","X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-Youtube-Chrome-Connected":"CHROME_CONNECTED_HEADER","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-YouTube-Delegation-Context":"INNERTUBE_CONTEXT_SERIALIZED_DELEGATION_CONTEXT","X-YouTube-Device":"DEVICE","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL","X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"},
ef="app debugcss debugjs expflag force_ad_params force_viral_ad_response_params forced_experiments innertube_snapshots innertube_goldens internalcountrycode internalipoverride absolute_experiments conditional_experiments sbb sr_bns_address client_dev_root_url".split(" "),ff=!1;
function gf(a,b){b=void 0===b?{}:b;if(!c)var c=window.location.href;var d=a.match(lb)[1]||null,e=nb(a);d&&e?(d=c,c=a.match(lb),d=d.match(lb),c=c[3]==d[3]&&c[1]==d[1]&&c[4]==d[4]):c=e?nb(c)==e&&(Number(c.match(lb)[4]||null)||null)==(Number(a.match(lb)[4]||null)||null):!0;d=T("web_ajax_ignore_global_headers_if_set");for(var f in df)e=R(df[f]),!e||!c&&nb(a)||d&&void 0!==b[f]||(b[f]=e);if(c||!nb(a))b["X-YouTube-Utc-Offset"]=String(-(new Date).getTimezoneOffset());(c||!nb(a))&&(f="undefined"!=typeof Intl?
(new Intl.DateTimeFormat).resolvedOptions().timeZone:null)&&(b["X-YouTube-Time-Zone"]=f);if(c||!nb(a))b["X-YouTube-Ad-Signals"]=Fe($e(void 0));return b}
function hf(a){var b=window.location.search,c=nb(a),d=mb(a.match(lb)[5]||null);d=(c=c&&(c.endsWith("youtube.com")||c.endsWith("youtube-nocookie.com")))&&d&&d.startsWith("/api/");if(!c||d)return a;var e=Ge(b),f={};J(ef,function(g){e[g]&&(f[g]=e[g])});
return He(a,f||{},!1)}
function jf(a,b){if(window.fetch&&"XML"!=b.format){var c={method:b.method||"GET",credentials:"same-origin"};b.headers&&(c.headers=b.headers);a=kf(a,b);var d=lf(a,b);d&&(c.body=d);b.withCredentials&&(c.credentials="include");var e=b.context||C,f=!1,g;fetch(a,c).then(function(h){if(!f){f=!0;g&&window.clearTimeout(g);var k=h.ok,l=function(m){m=m||{};k?b.onSuccess&&b.onSuccess.call(e,m,h):b.onError&&b.onError.call(e,m,h);b.onFinish&&b.onFinish.call(e,m,h)};
"JSON"==(b.format||"JSON")&&(k||400<=h.status&&500>h.status)?h.json().then(l,function(){l(null)}):l(null)}})["catch"](function(){b.onError&&b.onError.call(e,{},{})});
b.onFetchTimeout&&0<b.timeout&&(g=ye(function(){f||(f=!0,window.clearTimeout(g),b.onFetchTimeout.call(b.context||C))},b.timeout))}else mf(a,b)}
function mf(a,b){var c=b.format||"JSON";a=kf(a,b);var d=lf(a,b),e=!1,f=nf(a,function(k){if(!e){e=!0;h&&window.clearTimeout(h);a:switch(k&&"status"in k?k.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:var l=!0;break a;default:l=!1}var m=null,n=400<=k.status&&500>k.status,q=500<=k.status&&600>k.status;if(l||n||q)m=of(a,c,k,b.convertToSafeHtml);if(l)a:if(k&&204==k.status)l=!0;else{switch(c){case "XML":l=0==parseInt(m&&m.return_code,10);break a;case "RAW":l=!0;break a}l=
!!m}m=m||{};n=b.context||C;l?b.onSuccess&&b.onSuccess.call(n,k,m):b.onError&&b.onError.call(n,k,m);b.onFinish&&b.onFinish.call(n,k,m)}},b.method,d,b.headers,b.responseType,b.withCredentials);
if(b.onTimeout&&0<b.timeout){var g=b.onTimeout;var h=ye(function(){e||(e=!0,f.abort(),window.clearTimeout(h),g.call(b.context||C,f))},b.timeout)}}
function kf(a,b){b.includeDomain&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var c=R("XSRF_FIELD_NAME",void 0),d=b.urlParams;d&&(d[c]&&delete d[c],a=He(a,d||{},!0));return a}
function lf(a,b){var c=R("XSRF_FIELD_NAME",void 0),d=R("XSRF_TOKEN",void 0),e=b.postBody||"",f=b.postParams,g=R("XSRF_FIELD_NAME",void 0),h;b.headers&&(h=b.headers["Content-Type"]);b.excludeXsrf||nb(a)&&!b.withCredentials&&nb(a)!=document.location.hostname||"POST"!=b.method||h&&"application/x-www-form-urlencoded"!=h||b.postParams&&b.postParams[g]||(f||(f={}),f[c]=d);f&&"string"===typeof e&&(e=Ge(e),Xa(e,f),e=b.postBodyFormat&&"JSON"==b.postBodyFormat?JSON.stringify(e):qb(e));if(!(c=e)&&(c=f)){a:{for(var k in f){f=
!1;break a}f=!0}c=!f}!ff&&c&&"POST"!=b.method&&(ff=!0,oe(Error("AJAX request with postData should use POST")));return e}
function of(a,b,c,d){var e=null;switch(b){case "JSON":try{var f=c.responseText}catch(g){throw d=Error("Error reading responseText"),d.params=a,pe(d),g;}a=c.getResponseHeader("Content-Type")||"";f&&0<=a.indexOf("json")&&(")]}'\n"===f.substring(0,5)&&(f=f.substring(5)),e=JSON.parse(f));break;case "XML":if(a=(a=c.responseXML)?pf(a):null)e={},J(a.getElementsByTagName("*"),function(g){e[g.tagName]=qf(g)})}d&&rf(e);
return e}
function rf(a){if(F(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);if(c){c=b;var d=a[b];if(void 0===Ya){var e=null;var f=C.trustedTypes;if(f&&f.createPolicy){try{e=f.createPolicy("goog#html",{createHTML:Ga,createScript:Ga,createScriptURL:Ga})}catch(g){C.console&&C.console.error(g.message)}Ya=e}else Ya=e}d=(e=Ya)?e.createHTML(d):d;a[c]=new jb(d)}else rf(a[b])}}
function pf(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function qf(a){var b="";J(a.childNodes,function(c){b+=c.nodeValue});
return b}
function nf(a,b,c,d,e,f,g){function h(){4==(k&&"readyState"in k?k.readyState:0)&&b&&ne(b)(k)}
c=void 0===c?"GET":c;d=void 0===d?"":d;var k=cf();if(!k)return null;"onloadend"in k?k.addEventListener("loadend",h,!1):k.onreadystatechange=h;T("debug_forward_web_query_parameters")&&(a=hf(a));k.open(c,a,!0);f&&(k.responseType=f);g&&(k.withCredentials=!0);c="POST"==c&&(void 0===window.FormData||!(d instanceof FormData));if(e=gf(a,e))for(var l in e)k.setRequestHeader(l,e[l]),"content-type"==l.toLowerCase()&&(c=!1);c&&k.setRequestHeader("Content-Type","application/x-www-form-urlencoded");k.send(d);
return k}
;var sf=Jb||Kb;var tf={},uf=0;function vf(){var a=void 0===a?"":a;if(!wf(a))if(a=void 0===a?"":a)nf("/generate_204",void 0,"POST",a,void 0);else if(R("USE_NET_AJAX_FOR_PING_TRANSPORT",!1))nf("/generate_204",void 0,"GET","",void 0);else{a:{try{var b=new Ia;if(b.j&&b.i||b.l){var c=mb("/generate_204".match(lb)[5]||null);var d=!(!c||!c.endsWith("/aclk")||"1"!==sb("/generate_204","ri"));break a}}catch(e){}d=!1}d&&wf()||xf()}}
function wf(a){try{if(window.navigator&&window.navigator.sendBeacon&&window.navigator.sendBeacon("/generate_204",void 0===a?"":a))return!0}catch(b){}return!1}
function xf(){var a=new Image,b=""+uf++;tf[b]=a;a.onload=a.onerror=function(){delete tf[b]};
a.src="/generate_204"}
;var yf=C.ytPubsubPubsubInstance||new Q,zf=C.ytPubsubPubsubSubscribedKeys||{},Af=C.ytPubsubPubsubTopicToKeys||{},Bf=C.ytPubsubPubsubIsSynchronous||{};Q.prototype.subscribe=Q.prototype.subscribe;Q.prototype.unsubscribeByKey=Q.prototype.M;Q.prototype.publish=Q.prototype.J;Q.prototype.clear=Q.prototype.clear;H("ytPubsubPubsubInstance",yf);H("ytPubsubPubsubTopicToKeys",Af);H("ytPubsubPubsubIsSynchronous",Bf);H("ytPubsubPubsubSubscribedKeys",zf);var Cf=window,U=Cf.ytcsi&&Cf.ytcsi.now?Cf.ytcsi.now:Cf.performance&&Cf.performance.timing&&Cf.performance.now&&Cf.performance.timing.navigationStart?function(){return Cf.performance.timing.navigationStart+Cf.performance.now()}:function(){return(new Date).getTime()};var Df=Ue("initial_gel_batch_timeout",1E3),Ef=Math.pow(2,16)-1,Ff=null,Gf=0,Hf=void 0,If=0,Jf=0,Kf=0,Lf=!0,Mf=C.ytLoggingTransportGELQueue_||new Map;H("ytLoggingTransportGELQueue_",Mf);var Nf=C.ytLoggingTransportTokensToCttTargetIds_||{};H("ytLoggingTransportTokensToCttTargetIds_",Nf);
function Of(a,b){if("log_event"===a.endpoint){var c="";a.B&&(Nf[a.B.token]=Pf(a.B),c=a.B.token);var d=Mf.get(c)||[];Mf.set(c,d);d.push(a.payload);b&&(Hf=new b);c=Ue("web_logging_max_batch")||100;var e=U();d.length>=c?Qf({writeThenSend:!0}):10<=e-Kf&&(Rf(),Kf=e)}}
function Sf(a,b){if("log_event"===a.endpoint){var c="";a.B&&(Nf[a.B.token]=Pf(a.B),c=a.B.token);var d=new Map;d.set(c,[a.payload]);b&&(Hf=new b);return new O(function(e){Hf&&Hf.isReady()?Tf(d,e,{bypassNetworkless:!0}):e()})}}
function Qf(a){a=void 0===a?{}:a;return new O(function(b){window.clearTimeout(If);window.clearTimeout(Jf);Jf=0;Hf&&Hf.isReady()?(Tf(Mf,b,a),Mf.clear()):(Rf(),b())})}
function Rf(){T("web_gel_timeout_cap")&&!Jf&&(Jf=ye(Qf,6E4));window.clearTimeout(If);var a=R("LOGGING_BATCH_TIMEOUT",Ue("web_gel_debounce_ms",1E4));T("shorten_initial_gel_batch_timeout")&&Lf&&(a=Df);If=ye(function(){Qf({writeThenSend:!0})},a)}
function Tf(a,b,c){var d=Hf;c=void 0===c?{}:c;var e=Math.round(U()),f=a.size;a=u(a);for(var g=a.next();!g.done;g=a.next()){var h=u(g.value);g=h.next().value;var k=h.next().value;h=Va({context:Uf(d.h||Vf())});h.events=k;(k=Nf[g])&&Wf(h,g,k);delete Nf[g];Xf(h,e);T("send_beacon_before_gel")&&window.navigator&&window.navigator.sendBeacon&&!c.writeThenSend&&vf();Yf(d,"log_event",h,{retry:!0,onSuccess:function(){f--;f||b();Gf=Math.round(U()-e)},
onError:function(){f--;f||b()},
Z:c});Lf=!1}}
function Xf(a,b){a.requestTimeMs=String(b);T("unsplit_gel_payloads_in_logs")&&(a.unsplitGelPayloadsInLogs=!0);var c=R("EVENT_ID",void 0);if(c){var d=R("BATCH_CLIENT_COUNTER",void 0)||0;d||(d=Math.floor(Math.random()*Ef/2));d++;d>Ef&&(d=1);ke("BATCH_CLIENT_COUNTER",d);c={serializedEventId:c,clientCounter:String(d)};a.serializedClientEventId=c;Ff&&Gf&&T("log_gel_rtt_web")&&(a.previousBatchInfo={serializedClientEventId:Ff,roundtripMs:String(Gf)});Ff=c;Gf=0}}
function Wf(a,b,c){if(c.videoId)var d="VIDEO";else if(c.playlistId)d="PLAYLIST";else return;a.credentialTransferTokenTargetId=c;a.context=a.context||{};a.context.user=a.context.user||{};a.context.user.credentialTransferTokens=[{token:b,scope:d}]}
function Pf(a){var b={};a.videoId?b.videoId=a.videoId:a.playlistId&&(b.playlistId=a.playlistId);return b}
;var Zf=C.ytLoggingGelSequenceIdObj_||{};H("ytLoggingGelSequenceIdObj_",Zf);H("ytglobal.prefsUserPrefsPrefs_",E("ytglobal.prefsUserPrefsPrefs_")||{});var $f={bluetooth:"CONN_DISCO",cellular:"CONN_CELLULAR_UNKNOWN",ethernet:"CONN_WIFI",none:"CONN_NONE",wifi:"CONN_WIFI",wimax:"CONN_CELLULAR_4G",other:"CONN_UNKNOWN",unknown:"CONN_UNKNOWN","slow-2g":"CONN_CELLULAR_2G","2g":"CONN_CELLULAR_2G","3g":"CONN_CELLULAR_3G","4g":"CONN_CELLULAR_4G"};function ag(){return"INNERTUBE_API_KEY"in je&&"INNERTUBE_API_VERSION"in je}
function Vf(){return{innertubeApiKey:R("INNERTUBE_API_KEY",void 0),innertubeApiVersion:R("INNERTUBE_API_VERSION",void 0),ka:R("INNERTUBE_CONTEXT_CLIENT_CONFIG_INFO"),la:R("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),innertubeContextClientVersion:R("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0),na:R("INNERTUBE_CONTEXT_HL",void 0),ma:R("INNERTUBE_CONTEXT_GL",void 0),oa:R("INNERTUBE_HOST_OVERRIDE",void 0)||"",qa:!!R("INNERTUBE_USE_THIRD_PARTY_AUTH",!1),pa:!!R("INNERTUBE_OMIT_API_KEY_WHEN_AUTH_HEADER_IS_PRESENT",
!1),appInstallData:R("SERIALIZED_CLIENT_CONFIG_DATA",void 0)}}
function Uf(a){var b={client:{hl:a.na,gl:a.ma,clientName:a.la,clientVersion:a.innertubeContextClientVersion,configInfo:a.ka}},c=window.devicePixelRatio;c&&1!=c&&(b.client.screenDensityFloat=String(c));c=R("EXPERIMENTS_TOKEN","");""!==c&&(b.client.experimentsToken=c);c=[];var d=R("EXPERIMENTS_FORCED_FLAGS",{});for(e in d)c.push({key:e,value:String(d[e])});var e=R("EXPERIMENT_FLAGS",{});for(var f in e)f.startsWith("force_")&&void 0===d[f]&&c.push({key:f,value:String(e[f])});0<c.length&&(b.request={internalExperimentFlags:c});
a.appInstallData&&(b.client.configInfo=b.client.configInfo||{},b.client.configInfo.appInstallData=a.appInstallData);R("DELEGATED_SESSION_ID")&&!T("pageid_as_header_web")&&(b.user={onBehalfOfUser:R("DELEGATED_SESSION_ID")});a:{if(f=(a=C.navigator)?a.connection:void 0){a=$f[f.type||"unknown"]||"CONN_UNKNOWN";f=$f[f.effectiveType||"unknown"]||"CONN_UNKNOWN";"CONN_CELLULAR_UNKNOWN"===a&&"CONN_UNKNOWN"!==f&&(a=f);if("CONN_UNKNOWN"!==a)break a;if("CONN_UNKNOWN"!==f){a=f;break a}}a=void 0}a&&(b.client.connectionType=
a);a=Object;f=a.assign;e=b.client;c={};d=u(Object.entries(Ge(R("DEVICE",""))));for(var g=d.next();!g.done;g=d.next()){var h=u(g.value);g=h.next().value;h=h.next().value;"cbrand"===g?c.deviceMake=h:"cmodel"===g?c.deviceModel=h:"cbr"===g?c.browserName=h:"cbrver"===g?c.browserVersion=h:"cos"===g?c.osName=h:"cosver"===g?c.osVersion=h:"cplatform"===g&&(c.platform=h)}b.client=f.call(a,e,c);return b}
function bg(a,b,c){c=void 0===c?{}:c;var d={"X-Goog-Visitor-Id":c.visitorData||R("VISITOR_DATA","")};if(b&&b.includes("www.youtube-nocookie.com"))return d;(b=c.Ia||R("AUTHORIZATION"))||(a?b="Bearer "+E("gapi.auth.getToken")().Ha:b=xc([]));b&&(d.Authorization=b,d["X-Goog-AuthUser"]=R("SESSION_INDEX",0),T("pageid_as_header_web")&&(d["X-Goog-PageId"]=R("DELEGATED_SESSION_ID")));return d}
;function cg(a){a=Object.assign({},a);delete a.Authorization;var b=xc();if(b){var c=new Pc;c.update(R("INNERTUBE_API_KEY",void 0));c.update(b);b=c.digest();c=3;za(b);void 0===c&&(c=0);if(!Nb){Nb={};for(var d="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".split(""),e=["+/=","+/","-_=","-_.","-_"],f=0;5>f;f++){var g=d.concat(e[f].split(""));Mb[f]=g;for(var h=0;h<g.length;h++){var k=g[h];void 0===Nb[k]&&(Nb[k]=h)}}}c=Mb[c];d=[];for(e=0;e<b.length;e+=3){var l=b[e],m=(f=e+1<b.length)?
b[e+1]:0;k=(g=e+2<b.length)?b[e+2]:0;h=l>>2;l=(l&3)<<4|m>>4;m=(m&15)<<2|k>>6;k&=63;g||(k=64,f||(m=64));d.push(c[h],c[l],c[m]||"",c[k]||"")}a.hash=d.join("")}return a}
;function dg(a){var b=new ce;(b=b.isAvailable()?a?new ie(b,a):b:null)||(a=new de(a||"UserDataSharedStore"),b=a.isAvailable()?a:null);this.h=(a=b)?new Zd(a):null;this.i=document.domain||window.location.hostname}
dg.prototype.set=function(a,b,c,d){c=c||31104E3;this.remove(a);if(this.h)try{this.h.set(a,b,Date.now()+1E3*c);return}catch(f){}var e="";if(d)try{e=escape(Cd(b))}catch(f){return}else e=escape(b);b=this.i;nc.set(""+a,e,{S:c,path:"/",domain:void 0===b?"youtube.com":b,secure:!1})};
dg.prototype.get=function(a,b){var c=void 0,d=!this.h;if(!d)try{c=this.h.get(a)}catch(e){d=!0}if(d&&(c=nc.get(""+a,void 0))&&(c=unescape(c),b))try{c=JSON.parse(c)}catch(e){this.remove(a),c=void 0}return c};
dg.prototype.remove=function(a){this.h&&this.h.remove(a);var b=this.i;nc.remove(""+a,"/",void 0===b?"youtube.com":b)};var eg;function fg(){eg||(eg=new dg("yt.innertube"));return eg}
function gg(a,b,c,d){if(d)return null;d=fg().get("nextId",!0)||1;var e=fg().get("requests",!0)||{};e[d]={method:a,request:b,authState:cg(c),requestTime:Math.round(U())};fg().set("nextId",d+1,86400,!0);fg().set("requests",e,86400,!0);return d}
function hg(a){var b=fg().get("requests",!0)||{};delete b[a];fg().set("requests",b,86400,!0)}
function ig(a){var b=fg().get("requests",!0);if(b){for(var c in b){var d=b[c];if(!(6E4>Math.round(U())-d.requestTime)){var e=d.authState,f=cg(bg(!1));Ua(e,f)&&(e=d.request,"requestTimeMs"in e&&(e.requestTimeMs=Math.round(U())),Yf(a,d.method,e,{}));delete b[c]}}fg().set("requests",b,86400,!0)}}
;var jg=E("ytPubsub2Pubsub2Instance")||new Q;Q.prototype.subscribe=Q.prototype.subscribe;Q.prototype.unsubscribeByKey=Q.prototype.M;Q.prototype.publish=Q.prototype.J;Q.prototype.clear=Q.prototype.clear;H("ytPubsub2Pubsub2Instance",jg);H("ytPubsub2Pubsub2SubscribedKeys",E("ytPubsub2Pubsub2SubscribedKeys")||{});H("ytPubsub2Pubsub2TopicToKeys",E("ytPubsub2Pubsub2TopicToKeys")||{});H("ytPubsub2Pubsub2IsAsync",E("ytPubsub2Pubsub2IsAsync")||{});H("ytPubsub2Pubsub2SkipSubKey",null);var kg=[],lg=!1;function mg(a,b){lg||(kg.push({type:"EVENT",eventType:a,payload:b}),10<kg.length&&kg.shift())}
;function ng(a,b){for(var c=[],d=1;d<arguments.length;++d)c[d-1]=arguments[d];d=Error.call(this,a);this.message=d.message;"stack"in d&&(this.stack=d.stack);d=[];var e=d.concat;if(!(c instanceof Array)){c=u(c);for(var f,g=[];!(f=c.next()).done;)g.push(f.value);c=g}this.args=e.call(d,c)}
y(ng,Error);var og={},pg=(og.AUTH_INVALID="No user identifier specified.",og.EXPLICIT_ABORT="Transaction was explicitly aborted.",og.IDB_NOT_SUPPORTED="IndexedDB is not supported.",og.MISSING_OBJECT_STORE="Object store not created.",og.UNKNOWN_ABORT="Transaction was aborted for unknown reasons.",og.QUOTA_EXCEEDED="The current transaction exceeded its quota limitations.",og.QUOTA_MAYBE_EXCEEDED="The current transaction may have failed because of exceeding quota limitations.",og.EXECUTE_TRANSACTION_ON_CLOSED_DB=
"Can't start a transaction on a closed database",og),qg={},rg=(qg.AUTH_INVALID="ERROR",qg.EXECUTE_TRANSACTION_ON_CLOSED_DB="WARNING",qg.EXPLICIT_ABORT="IGNORED",qg.IDB_NOT_SUPPORTED="ERROR",qg.MISSING_OBJECT_STORE="ERROR",qg.QUOTA_EXCEEDED="WARNING",qg.QUOTA_MAYBE_EXCEEDED="WARNING",qg.UNKNOWN_ABORT="WARNING",qg);
function V(a,b,c,d){b=void 0===b?{}:b;c=void 0===c?pg[a]:c;d=void 0===d?rg[a]:d;ng.call(this,c,Object.assign({name:"YtIdbKnownError",isSw:void 0===self.document,isIframe:self!==self.top,type:a},b));this.type=a;this.message=c;this.level=d;Object.setPrototypeOf(this,V.prototype)}
y(V,ng);function sg(a){V.call(this,"MISSING_OBJECT_STORE",{Oa:a},pg.MISSING_OBJECT_STORE);Object.setPrototypeOf(this,sg.prototype)}
y(sg,V);var tg=["The database connection is closing","Can't start a transaction on a closed database","A mutation operation was attempted on a database that did not allow mutations"];
function ug(a,b,c){var d=a instanceof Error?a:Error("Unexpected error: "+a);if(d instanceof V)return d;if("QuotaExceededError"===d.name)return new V("QUOTA_EXCEEDED",{objectStoreNames:c,dbName:b});if(Lb&&"UnknownError"===d.name)return new V("QUOTA_MAYBE_EXCEEDED",{objectStoreNames:c,dbName:b});if("InvalidStateError"===d.name&&tg.some(function(e){return d.message.includes(e)}))return new V("EXECUTE_TRANSACTION_ON_CLOSED_DB",{objectStoreNames:c,
dbName:b});d.args=[{name:"IdbError",Pa:d.name,dbName:b,objectStoreNames:c}];d.level="WARNING";return d}
;function vg(a){if(!a)throw Error();throw a;}
function wg(a){return a}
function W(a){function b(e){if("PENDING"===d.state.status){d.state={status:"REJECTED",reason:e};e=u(d.onRejected);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
function c(e){if("PENDING"===d.state.status){d.state={status:"FULFILLED",value:e};e=u(d.h);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
var d=this;this.i=a;this.state={status:"PENDING"};this.h=[];this.onRejected=[];try{this.i(c,b)}catch(e){b(e)}}
W.all=function(a){return new W(function(b,c){var d=[],e=a.length;0===e&&b(d);for(var f={H:0};f.H<a.length;f={H:f.H},++f.H)xg(W.resolve(a[f.H]).then(function(g){return function(h){d[g.H]=h;e--;0===e&&b(d)}}(f)),function(g){c(g)})})};
W.resolve=function(a){return new W(function(b,c){a instanceof W?a.then(b,c):b(a)})};
W.reject=function(a){return new W(function(b,c){c(a)})};
W.prototype.then=function(a,b){var c=this,d=null!==a&&void 0!==a?a:wg,e=null!==b&&void 0!==b?b:vg;return new W(function(f,g){"PENDING"===c.state.status?(c.h.push(function(){yg(c,c,d,f,g)}),c.onRejected.push(function(){zg(c,c,e,f,g)})):"FULFILLED"===c.state.status?yg(c,c,d,f,g):"REJECTED"===c.state.status&&zg(c,c,e,f,g)})};
function xg(a,b){a.then(void 0,b)}
function yg(a,b,c,d,e){try{if("FULFILLED"!==a.state.status)throw Error("calling handleResolve before the promise is fulfilled.");var f=c(a.state.value);f instanceof W?Ag(a,b,f,d,e):d(f)}catch(g){e(g)}}
function zg(a,b,c,d,e){try{if("REJECTED"!==a.state.status)throw Error("calling handleReject before the promise is rejected.");var f=c(a.state.reason);f instanceof W?Ag(a,b,f,d,e):d(f)}catch(g){e(g)}}
function Ag(a,b,c,d,e){b===c?e(new TypeError("Circular promise chain detected.")):c.then(function(f){f instanceof W?Ag(a,b,f,d,e):d(f)},function(f){e(f)})}
;function Bg(a,b,c){function d(){c(a.error);f()}
function e(){b(a.result);f()}
function f(){try{a.removeEventListener("success",e),a.removeEventListener("error",d)}catch(g){}}
a.addEventListener("success",e);a.addEventListener("error",d)}
function Cg(a){return new Promise(function(b,c){Bg(a,b,c)})}
function X(a){return new W(function(b,c){Bg(a,b,c)})}
;function Dg(a,b){return new W(function(c,d){function e(){var f=a?b(a):null;f?f.then(function(g){a=g;e()},d):c()}
e()})}
;function Eg(a,b){this.h=a;this.options=b;this.transactionCount=0;this.j=Math.round(U());this.i=!1}
r=Eg.prototype;r.add=function(a,b,c){return Fg(this,[a],{mode:"readwrite",I:T("ytidb_transaction_enable_retries_core_and_nwl")},function(d){return Gg(d,a).add(b,c)})};
r.clear=function(a){return Fg(this,[a],{mode:"readwrite",I:T("ytidb_transaction_enable_retries_core_and_nwl")},function(b){return Gg(b,a).clear()})};
r.close=function(){var a;this.h.close();(null===(a=this.options)||void 0===a?0:a.closed)&&this.options.closed()};
r.count=function(a,b){return Fg(this,[a],{mode:"readonly",I:T("ytidb_transaction_enable_retries_core_and_nwl")},function(c){return Gg(c,a).count(b)})};
r["delete"]=function(a,b){return Fg(this,[a],{mode:"readwrite",I:T("ytidb_transaction_enable_retries_core_and_nwl")},function(c){return Gg(c,a)["delete"](b)})};
r.get=function(a,b){return Fg(this,[a],{mode:"readonly",I:T("ytidb_transaction_enable_retries_core_and_nwl")},function(c){return Gg(c,a).get(b)})};
function Fg(a,b,c,d){return L(a,function f(){var g=this,h,k,l,m,n,q,p,v,w,x,D;return A(f,function(G){switch(G.h){case 1:var P={mode:"readonly",I:!1};"string"===typeof c?P.mode=c:P=c;h=P;g.transactionCount++;k=h.I?Ue("ytidb_transaction_try_count",1):1;case 2:if(l){G.h=3;break}k--;m=Math.round(U());G.m=4;n=g.h.transaction(b,h.mode);P=new Hg(n);P=Ig(P,d);return z(G,P,6);case 6:return q=G.i,p=Math.round(U()),Jg(g,m,p,void 0,b.join(),h),G["return"](q);case 4:v=pa(G);w=Math.round(U());x=ug(v,g.h.name,b.join());
if((D=x instanceof V&&"EXPLICIT_ABORT"===x.type)||0>=k)Jg(g,m,w,x,b.join(),h),l=x;G.h=2;break;case 3:return G["return"](Promise.reject(l))}})})}
function Jg(a,b,c,d,e,f){b=c-b;d?(d instanceof V&&("QUOTA_EXCEEDED"===d.type||"QUOTA_MAYBE_EXCEEDED"===d.type)&&mg("QUOTA_EXCEEDED",{dbName:a.h.name,objectStoreNames:e,transactionCount:a.transactionCount,transactionMode:f.mode}),d instanceof V&&"UNKNOWN_ABORT"===d.type&&(mg("TRANSACTION_UNEXPECTEDLY_ABORTED",{objectStoreNames:e,transactionDuration:b,transactionCount:a.transactionCount,dbDuration:c-a.j}),a.i=!0),Kg(a,!1,e,b),lg||(kg.push({type:"ERROR",payload:d}),10<kg.length&&kg.shift())):Kg(a,!0,
e,b)}
function Kg(a,b,c,d){mg("TRANSACTION_ENDED",{objectStoreNames:c,connectionHasUnknownAbortedTransaction:a.i,duration:d,isSuccessful:b})}
function Lg(a){this.h=a}
r=Lg.prototype;r.add=function(a,b){return X(this.h.add(a,b))};
r.clear=function(){return X(this.h.clear()).then(function(){})};
r.count=function(a){return X(this.h.count(a))};
function Mg(a,b){return Ng(a,{query:b},function(c){return c["delete"]().then(function(){return c["continue"]()})}).then(function(){})}
r["delete"]=function(a){return a instanceof IDBKeyRange?Mg(this,a):X(this.h["delete"](a))};
r.get=function(a){return X(this.h.get(a))};
r.index=function(a){return new Og(this.h.index(a))};
r.getName=function(){return this.h.name};
function Ng(a,b,c){a=a.h.openCursor(b.query,b.direction);return Pg(a).then(function(d){return Dg(d,c)})}
function Hg(a){var b=this;this.h=a;this.i=new Map;this.aborted=!1;this.done=new Promise(function(c,d){b.h.addEventListener("complete",function(){c()});
b.h.addEventListener("error",function(e){e.currentTarget===e.target&&d(b.h.error)});
b.h.addEventListener("abort",function(){var e=b.h.error;if(e)d(e);else if(!b.aborted){e=V;for(var f=b.h.objectStoreNames,g=[],h=0;h<f.length;h++){var k=f.item(h);if(null===k)throw Error("Invariant: item in DOMStringList is null");g.push(k)}e=new e("UNKNOWN_ABORT",{objectStoreNames:g.join(),dbName:b.h.db.name,mode:b.h.mode});d(e)}})})}
function Ig(a,b){var c=new Promise(function(d,e){xg(b(a).then(function(f){a.commit();d(f)}),e)});
return Promise.all([c,a.done]).then(function(d){return u(d).next().value})}
Hg.prototype.abort=function(){this.h.abort();this.aborted=!0;throw new V("EXPLICIT_ABORT");};
Hg.prototype.commit=function(){var a=this.h;a.commit&&!this.aborted&&a.commit()};
function Gg(a,b){var c=a.h.objectStore(b),d=a.i.get(c);d||(d=new Lg(c),a.i.set(c,d));return d}
function Og(a){this.h=a}
Og.prototype.count=function(a){return X(this.h.count(a))};
Og.prototype["delete"]=function(a){return Qg(this,{query:a},function(b){return b["delete"]().then(function(){return b["continue"]()})})};
Og.prototype.get=function(a){return X(this.h.get(a))};
Og.prototype.getKey=function(a){return X(this.h.getKey(a))};
function Qg(a,b,c){a=a.h.openCursor(void 0===b.query?null:b.query,void 0===b.direction?"next":b.direction);return Pg(a).then(function(d){return Dg(d,c)})}
function Rg(a,b){this.request=a;this.cursor=b}
function Pg(a){return X(a).then(function(b){return null===b?null:new Rg(a,b)})}
r=Rg.prototype;r.advance=function(a){this.cursor.advance(a);return Pg(this.request)};
r["continue"]=function(a){this.cursor["continue"](a);return Pg(this.request)};
r["delete"]=function(){return X(this.cursor["delete"]()).then(function(){})};
r.getKey=function(){return this.cursor.key};
r.update=function(a){return X(this.cursor.update(a))};function Sg(a,b,c){return L(this,function e(){var f,g,h,k,l,m,n,q,p,v;return A(e,function(w){if(1==w.h)return f=self.indexedDB.open(a,b),g=c,h=g.blocked,k=g.blocking,l=g.va,m=g.upgrade,n=g.closed,p=function(){q||(q=new Eg(f.result,{closed:n}));return q},f.addEventListener("upgradeneeded",function(x){if(null===x.newVersion)throw Error("Invariant: newVersion on IDbVersionChangeEvent is null");
if(null===f.transaction)throw Error("Invariant: transaction on IDbOpenDbRequest is null");x.dataLoss&&"none"!==x.dataLoss&&mg("IDB_DATA_CORRUPTED",{reason:x.dataLossMessage||"unknown reason",dbName:a});var D=p(),G=new Hg(f.transaction);m&&m(D,x.oldVersion,x.newVersion,G)}),h&&f.addEventListener("blocked",function(){h()}),z(w,Cg(f),2);
v=w.i;k&&v.addEventListener("versionchange",function(){k(p())});
v.addEventListener("close",function(){mg("IDB_UNEXPECTEDLY_CLOSED",{dbName:a,dbVersion:v.version});l&&l()});
return w["return"](p())})})}
function Tg(a,b){b=void 0===b?{}:b;return L(this,function d(){var e,f,g;return A(d,function(h){e=self.indexedDB.deleteDatabase(a);f=b;(g=f.blocked)&&e.addEventListener("blocked",function(){g()});
return z(h,Cg(e),0)})})}
;function Ug(a){this.name="YtIdbMeta";this.options=a;this.i=!1}
function Vg(a,b,c){c=void 0===c?{}:c;c=void 0===c?{}:c;return Sg(a,b,c)}
Ug.prototype["delete"]=function(a){a=void 0===a?{}:a;return Tg(this.name,a)};
Ug.prototype.open=function(){var a=this;if(!this.h){var b,c=function(){a.h===b&&(a.h=void 0)},d={blocking:function(f){f.close()},
closed:c,va:c,upgrade:this.options.upgrade},e=function(){return L(a,function g(){var h=this,k,l,m;return A(g,function(n){switch(n.h){case 1:return n.m=2,z(n,Vg(h.name,h.options.version,d),4);case 4:k=n.i;a:{var q=u(Object.keys(h.options.ta));for(var p=q.next();!p.done;p=q.next())if(p=p.value,!k.h.objectStoreNames.contains(p)){q=p;break a}q=void 0}l=q;if(void 0===l){n.h=5;break}if(h.i){n.h=6;break}h.i=!0;return z(n,h["delete"](),7);case 7:return n["return"](e());case 6:throw new sg(l);case 5:return n["return"](k);
case 2:m=pa(n);if(m instanceof DOMException?"VersionError"===m.name:"DOMError"in self&&m instanceof DOMError?"VersionError"===m.name:m instanceof Object&&"message"in m&&"An attempt was made to open a database using a lower version than the existing version."===m.message)return n["return"](Vg(h.name,void 0,Object.assign(Object.assign({},d),{upgrade:void 0})));c();throw m;}})})};
this.h=b=e()}return this.h};var Wg=new Ug({ta:{databases:!0},upgrade:function(a,b){1>b&&a.h.createObjectStore("databases",{keyPath:"actualName"})}});
function Xg(a){return L(this,function c(){var d;return A(c,function(e){if(1==e.h)return z(e,Wg.open(),2);d=e.i;return e["return"](Fg(d,["databases"],"readwrite",function(f){var g=Gg(f,"databases");return g.get(a.actualName).then(function(h){if(h?a.actualName!==h.actualName||a.publicName!==h.publicName||a.userIdentifier!==h.userIdentifier||a.clearDataOnAuthChange!==h.clearDataOnAuthChange:1)return X(g.h.put(a,void 0)).then(function(){})})}))})})}
function Yg(){return L(this,function b(){var c;return A(b,function(d){if(1==d.h)return z(d,Wg.open(),2);c=d.i;return d["return"](c["delete"]("databases","yt-idb-test-do-not-use"))})})}
;var Zg;
function $g(){return L(this,function b(){var c,d;return A(b,function(e){switch(e.h){case 1:var f;if(f=sf)f=/WebKit\/([0-9]+)/.exec(gb),f=!!(f&&600<=parseInt(f[1],10));f&&(f=/WebKit\/([0-9]+)/.exec(gb),f=!(f&&602<=parseInt(f[1],10)));if(f&&!T("ytidb_allow_on_ios_safari_v8_and_v9")||xb)return e["return"](!1);try{if(c=self,!(c.indexedDB&&c.IDBIndex&&c.IDBKeyRange&&c.IDBObjectStore))return e["return"](!1)}catch(g){return e["return"](!1)}if(!("IDBTransaction"in self&&"objectStoreNames"in IDBTransaction.prototype))return e["return"](!1);e.m=
2;d={actualName:"yt-idb-test-do-not-use",publicName:"yt-idb-test-do-not-use",userIdentifier:void 0};return z(e,Xg(d),4);case 4:return z(e,Yg(),5);case 5:return e["return"](!0);case 2:return pa(e),e["return"](!1)}})})}
function ah(){if(void 0!==Zg)return Zg;lg=!0;return Zg=$g().then(function(a){lg=!1;return a})}
;var bh;function ch(){bh||(bh=new dg("yt.offline"));return bh}
;function dh(){N.call(this);this.s=this.u=this.C=this.l=!1;this.i=eh();this.s=T("validate_network_status");fh(this);gh(this)}
y(dh,N);function eh(){var a=window.navigator.onLine;return void 0===a?!0:a}
function gh(a){window.addEventListener("online",function(){return L(a,function c(){var d=this;return A(c,function(e){if(1==e.h){if(!d.s){d.i=!0;e.h=2;return}return z(e,hh(d),3)}2!=e.h&&(d.i=e.i);d.l&&d.i&&Ad(d,"ytnetworkstatus-online");ih(d);if(d.u&&T("offline_error_handling")){var f=ch().get("errors",!0);if(f){for(var g in f)if(f[g]){var h=new ng(g,"sent via offline_errors");h.name=f[g].name;h.stack=f[g].stack;h.level=f[g].level;oe(h)}ch().set("errors",{},2592E3,!0)}}e.h=0})})})}
function fh(a){window.addEventListener("offline",function(){return L(a,function c(){var d=this;return A(c,function(e){if(1==e.h){if(!d.s){d.i=!1;e.h=2;return}return z(e,hh(d),3)}2!=e.h&&(d.i=e.i);d.l&&!d.i&&Ad(d,"ytnetworkstatus-offline");ih(d);e.h=0})})})}
function ih(a){a.C&&(pe(new ng("NetworkStatusManager state did not match poll",U()-0)),a.C=!1)}
function hh(a){return L(a,function c(){var d;return A(c,function(e){switch(e.h){case 1:return e.m=2,z(e,fetch("/generate_204",{method:"HEAD"}),4);case 4:d=!0;e.h=3;e.m=0;break;case 2:pa(e),d=!1;case 3:return e["return"](d)}})})}
;function jh(a){a=void 0===a?{}:a;N.call(this);var b=this;this.l=this.u=0;dh.h||(dh.h=new dh);this.i=dh.h;this.i.l=!0;a.sa&&(this.i.u=!0);a.R?(this.R=a.R,rd(this.i,"ytnetworkstatus-online",function(){kh(b,"publicytnetworkstatus-online")}),rd(this.i,"ytnetworkstatus-offline",function(){kh(b,"publicytnetworkstatus-offline")})):(rd(this.i,"ytnetworkstatus-online",function(){Ad(b,"publicytnetworkstatus-online")}),rd(this.i,"ytnetworkstatus-offline",function(){Ad(b,"publicytnetworkstatus-offline")}))}
y(jh,N);function kh(a,b){a.R?a.l?(Ze(a.u),a.u=We(function(){a.s!==b&&(Ad(a,b),a.s=b,a.l=U())},a.R-(U()-a.l))):(Ad(a,b),a.s=b,a.l=U()):Ad(a,b)}
;var lh;function mh(a,b){b=void 0===b?{}:b;ah().then(function(){lh||(lh=new jh({sa:!0}));lh.i.i!==eh()&&pe(new ng("NetworkStatusManager isOnline does not match window status"));mf(a,b)})}
function nh(a,b){b=void 0===b?{}:b;ah().then(function(){mf(a,b)})}
;function oh(a){var b=this;this.h=null;a?this.h=a:ag()&&(this.h=Vf());Xe(function(){ig(b)},0,5E3)}
oh.prototype.isReady=function(){!this.h&&ag()&&(this.h=Vf());return!!this.h};
function Yf(a,b,c,d){!R("VISITOR_DATA")&&"visitor_id"!==b&&.01>Math.random()&&pe(new ng("Missing VISITOR_DATA when sending innertube request.",b,c,d));if(!a.isReady()){var e=new ng("innertube xhrclient not ready",b,c,d);oe(e);throw e;}var f={headers:{"Content-Type":"application/json"},method:"POST",postParams:c,postBodyFormat:"JSON",onTimeout:function(){d.onTimeout()},
onFetchTimeout:d.onTimeout,onSuccess:function(n,q){if(d.onSuccess)d.onSuccess(q)},
onFetchSuccess:function(n){if(d.onSuccess)d.onSuccess(n)},
onError:function(n,q){if(d.onError)d.onError(q)},
onFetchError:function(n){if(d.onError)d.onError(n)},
timeout:d.timeout,withCredentials:!0},g="";(e=a.h.oa)&&(g=e);var h=a.h.qa||!1,k=bg(h,g,d);Object.assign(f.headers,k);f.headers.Authorization&&!g&&(f.headers["x-origin"]=window.location.origin);e="/youtubei/"+a.h.innertubeApiVersion+"/"+b;var l={alt:"json"};a.h.pa&&f.headers.Authorization||(l.key=a.h.innertubeApiKey);var m=He(""+g+e,l||{},!0);(function(n){n=void 0===n?!1:n;var q;if(d.retry&&T("retry_web_logging_batches")&&"www.youtube-nocookie.com"!=g&&(n||(q=gg(b,c,k,h)),q)){var p=f.onSuccess,v=f.onFetchSuccess;
f.onSuccess=function(w,x){hg(q);p(w,x)};
c.onFetchSuccess=function(w,x){hg(q);v(w,x)}}try{T("use_fetch_for_op_xhr")?jf(m,f):n&&d.retry&&!d.Z.bypassNetworkless?(f.method="POST",!d.Z.writeThenSend&&T("nwl_send_fast_on_unload")?nh(m,f):mh(m,f)):(f.method="POST",f.postParams||(f.postParams={}),mf(m,f))}catch(w){if("InvalidAccessError"==w.name)q&&(hg(q),q=0),pe(Error("An extension is blocking network request."));
else throw w;}q&&Xe(function(){ig(a)},0,5E3)})(!1)}
;function ph(a,b){var c=void 0===c?{}:c;var d=oh;R("ytLoggingEventsDefaultDisabled",!1)&&oh==oh&&(d=null);c=void 0===c?{}:c;var e={};e.eventTimeMs=Math.round(c.timestamp||U());e[a]=b;var f=E("_lact",window);f=null==f?-1:Math.max(Date.now()-f,0);e.context={lastActivityMs:String(c.timestamp||!isFinite(f)?-1:f)};if(T("log_sequence_info_on_gel_web")&&c.ca){f=e.context;var g=c.ca;Zf[g]=g in Zf?Zf[g]+1:0;f.sequence={index:Zf[g],groupKey:g};c.Ma&&delete Zf[c.ca]}(c.Ra?Sf:Of)({endpoint:"log_event",payload:e,
B:c.B},d)}
;var qh=[{Y:function(a){return"Cannot read property '"+a.key+"'"},
T:{TypeError:[{regexp:/Cannot read property '([^']+)' of (null|undefined)/,groups:["key","value"]},{regexp:/\u65e0\u6cd5\u83b7\u53d6\u672a\u5b9a\u4e49\u6216 (null|undefined) \u5f15\u7528\u7684\u5c5e\u6027\u201c([^\u201d]+)\u201d/,groups:["value","key"]},{regexp:/\uc815\uc758\ub418\uc9c0 \uc54a\uc74c \ub610\ub294 (null|undefined) \ucc38\uc870\uc778 '([^']+)' \uc18d\uc131\uc744 \uac00\uc838\uc62c \uc218 \uc5c6\uc2b5\ub2c8\ub2e4./,groups:["value","key"]},{regexp:/No se puede obtener la propiedad '([^']+)' de referencia nula o sin definir/,
groups:["key"]},{regexp:/Unable to get property '([^']+)' of (undefined or null) reference/,groups:["key","value"]}],Error:[{regexp:/(Permission denied) to access property "([^']+)"/,groups:["reason","key"]}]}},{Y:function(a){return"Cannot call '"+a.key+"'"},
T:{TypeError:[{regexp:/(?:([^ ]+)?\.)?([^ ]+) is not a function/,groups:["base","key"]},{regexp:/([^ ]+) called on (null or undefined)/,groups:["key","value"]},{regexp:/Object (.*) has no method '([^ ]+)'/,groups:["base","key"]},{regexp:/Object doesn't support property or method '([^ ]+)'/,groups:["key"]},{regexp:/\u30aa\u30d6\u30b8\u30a7\u30af\u30c8\u306f '([^']+)' \u30d7\u30ed\u30d1\u30c6\u30a3\u307e\u305f\u306f\u30e1\u30bd\u30c3\u30c9\u3092\u30b5\u30dd\u30fc\u30c8\u3057\u3066\u3044\u307e\u305b\u3093/,
groups:["key"]},{regexp:/\uac1c\uccb4\uac00 '([^']+)' \uc18d\uc131\uc774\ub098 \uba54\uc11c\ub4dc\ub97c \uc9c0\uc6d0\ud558\uc9c0 \uc54a\uc2b5\ub2c8\ub2e4./,groups:["key"]}]}}];function rh(){this.h=[];this.i=[]}
var sh;function th(){sh||(sh=new rh);return sh}
;var uh=new Q;function vh(a){function b(){return a.charCodeAt(d++)}
var c=a.length,d=0;do{var e=wh(b);if(Infinity===e)break;var f=e>>3;switch(e&7){case 0:e=wh(b);if(2===f)return e;break;case 1:if(2===f)return;d+=8;break;case 2:e=wh(b);if(2===f)return a.substr(d,e);d+=e;break;case 5:if(2===f)return;d+=4;break;default:return}}while(d<c)}
function wh(a){var b=a(),c=b&127;if(128>b)return c;b=a();c|=(b&127)<<7;if(128>b)return c;b=a();c|=(b&127)<<14;if(128>b)return c;b=a();return 128>b?c|(b&127)<<21:Infinity}
;function xh(a,b,c,d){if(a)if(Array.isArray(a)){var e=d;for(d=0;d<a.length&&!(a[d]&&(e+=yh(d,a[d],b,c),500<e));d++);d=e}else if("object"===typeof a)for(e in a){if(a[e]){var f=e;var g=a[e],h=b,k=c;f="string"!==typeof g||"clickTrackingParams"!==f&&"trackingParams"!==f?0:(g=vh(atob(g.replace(/-/g,"+").replace(/_/g,"/"))))?yh(f+".ve",g,h,k):0;d+=f;d+=yh(e,a[e],b,c);if(500<d)break}}else c[b]=zh(a),d+=c[b].length;else c[b]=zh(a),d+=c[b].length;return d}
function yh(a,b,c,d){c+="."+a;a=zh(b);d[c]=a;return c.length+a.length}
function zh(a){return("string"===typeof a?a:String(JSON.stringify(a))).substr(0,500)}
;var Ah=new Set,Bh=0,Ch=0,Dh=0,Eh=[],Fh=["PhantomJS","Googlebot","TO STOP THIS SECURITY SCAN go/scan"];function Y(a,b,c){this.o=this.h=this.i=null;this.m=Aa(this);this.j=0;this.u=!1;this.s=[];this.l=null;this.C=c;this.D={};c=document;if(a="string"===typeof a?c.getElementById(a):a)if(c="iframe"==a.tagName.toLowerCase(),b.host||(b.host=c?ob(a.src):"https://www.youtube.com"),this.i=new Qe(b),c||(b=Gh(this,a),this.o=a,(c=a.parentNode)&&c.replaceChild(b,a),a=b),this.h=a,this.h.id||(this.h.id="widget"+Aa(this.h)),Ke[this.h.id]=this,window.postMessage){this.l=new Q;Hh(this);b=S(this.i,"events");for(var d in b)b.hasOwnProperty(d)&&
this.addEventListener(d,b[d]);for(var e in Me)Ih(this,e)}}
r=Y.prototype;r.setSize=function(a,b){this.h.width=a;this.h.height=b;return this};
r.ia=function(){return this.h};
r.ba=function(a){Jh(this,a.event,a)};
r.addEventListener=function(a,b){var c=b;"string"==typeof b&&(c=function(){window[b].apply(window,arguments)});
if(!c)return this;this.l.subscribe(a,c);Kh(this,a);return this};
function Ih(a,b){var c=b.split(".");if(2==c.length){var d=c[1];a.C==c[0]&&Kh(a,d)}}
r.destroy=function(){this.h.id&&(Ke[this.h.id]=null);var a=this.l;a&&"function"==typeof a.dispose&&a.dispose();if(this.o){a=this.h;var b=a.parentNode;b&&b.replaceChild(this.o,a)}else(a=this.h)&&a.parentNode&&a.parentNode.removeChild(a);Se&&(Se[this.m]=null);this.i=null;a=this.h;for(var c in Ta)Ta[c][0]==a&&ve(c);this.o=this.h=null};
r.W=function(){return{}};
function Lh(a,b,c){c=c||[];c=Array.prototype.slice.call(c);b={event:"command",func:b,args:c};a.u?a.U(b):a.s.push(b)}
function Jh(a,b,c){a.l.j||(c={target:a,data:c},a.l.J(b,c),Pe(a.C+"."+b,c))}
function Gh(a,b){for(var c=document.createElement("iframe"),d=b.attributes,e=0,f=d.length;e<f;e++){var g=d[e].value;null!=g&&""!=g&&"null"!=g&&c.setAttribute(d[e].name,g)}c.setAttribute("frameBorder",0);c.setAttribute("allowfullscreen",1);c.setAttribute("allow","accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");c.setAttribute("title","YouTube "+S(a.i,"title"));(d=S(a.i,"width"))&&c.setAttribute("width",d);(d=S(a.i,"height"))&&c.setAttribute("height",d);var h=
a.W();h.enablejsapi=window.postMessage?1:0;window.location.host&&(h.origin=window.location.protocol+"//"+window.location.host);h.widgetid=a.m;window.location.href&&J(["debugjs","debugcss"],function(k){var l=sb(window.location.href,k);null!==l&&(h[k]=l)});
c.src=S(a.i,"host")+("/embed/"+S(a.i,"videoId"))+"?"+qb(h);return c}
r.aa=function(){this.h&&this.h.contentWindow?this.U({event:"listening"}):window.clearInterval(this.j)};
function Hh(a){Re(a.i,a,a.m);a.j=ze(Fa(a.aa,a));xe(a.h,"load",Fa(function(){window.clearInterval(this.j);this.j=ze(Fa(this.aa,this))},a))}
function Kh(a,b){a.D[b]||(a.D[b]=!0,Lh(a,"addEventListener",[b]))}
r.U=function(a){a.id=this.m;a.channel="widget";a=Cd(a);var b=this.i;var c=ob(this.h.src||"");b=0==c.indexOf("https:")?[c]:b.h?[c.replace("http:","https:")]:b.j?[c]:[c,c.replace("http:","https:")];if(this.h.contentWindow)for(c=0;c<b.length;c++)try{this.h.contentWindow.postMessage(a,b[c])}catch(D){if(D.name&&"SyntaxError"==D.name){if(!(D.message&&0<D.message.indexOf("target origin ''"))){var d=void 0,e=D;d=void 0===d?{}:d;d.name=R("INNERTUBE_CONTEXT_CLIENT_NAME",1);d.version=R("INNERTUBE_CONTEXT_CLIENT_VERSION",
void 0);var f=d||{};d="WARNING";d=void 0===d?"ERROR":d;if(e){e.level&&(d=e.level);if(T("console_log_js_exceptions")){var g=e,h=[];h.push("Name: "+g.name);h.push("Message: "+g.message);g.hasOwnProperty("params")&&h.push("Error Params: "+JSON.stringify(g.params));g.hasOwnProperty("args")&&h.push("Error args: "+JSON.stringify(g.args));h.push("File name: "+g.fileName);h.push("Stacktrace: "+g.stack);window.console.log(h.join("\n"),g)}if(!(5<=Bh)){var k=f,l=Eh,m=ic(e);f=m.message||"Unknown Error";g=m.name||
"UnknownError";var n=m.stack||e.h||"Not available";n.startsWith(g+": "+f)&&(h=n.split("\n"),h.shift(),n=h.join("\n"));h=m.lineNumber||"Not available";m=m.fileName||"Not available";var q=void 0,p=e,v=0;if(p.hasOwnProperty("args")&&p.args&&p.args.length)for(q=0;q<p.args.length&&!(v=xh(p.args[q],"params."+q,k,v),500<=v);q++);else if(p.hasOwnProperty("params")&&p.params){var w=p.params;if("object"===typeof p.params)for(q in w){if(w[q]){p="params."+q;var x=zh(w[q]);k[p]=x;v+=p.length+x.length;if(500<v)break}}else k.params=
zh(w)}if(l.length)for(q=0;q<l.length&&!(v=xh(l[q],"params.context."+q,k,v),500<=v);q++);navigator.vendor&&!k.hasOwnProperty("vendor")&&(k["device.vendor"]=navigator.vendor);f={message:f,name:g,lineNumber:h,fileName:m,stack:n,params:k,sampleWeight:1};g=Number(e.columnNumber);isNaN(g)||(f.lineNumber=f.lineNumber+":"+g);if("IGNORED"===e.level)e=0;else a:{e=f;g=th();h=u(g.i);for(m=h.next();!m.done;m=h.next())if(m=m.value,e.message&&e.message.match(m.Na)){e=m.weight;break a}g=u(g.h);for(h=g.next();!h.done;h=
g.next())if(h=h.value,h.Ka(e)){e=h.weight;break a}e=1}f.sampleWeight=e;e=f;f=u(qh);for(g=f.next();!g.done;g=f.next())if(g=g.value,g.T[e.name])for(m=u(g.T[e.name]),h=m.next();!h.done;h=m.next())if(n=h.value,h=e.message.match(n.regexp)){e.params["params.error.original"]=h[0];m=n.groups;n={};for(k=0;k<m.length;k++)n[m[k]]=h[k+1],e.params["params.error."+m[k]]=h[k+1];e.message=g.Y(n);break}e.params||(e.params={});f=th();e.params["params.errorServiceSignature"]="msg="+f.i.length+"&cb="+f.h.length;e.params["params.serviceWorker"]=
"false";C.document&&C.document.querySelectorAll&&(e.params["params.fscripts"]=String(document.querySelectorAll("script:not([nonce])").length));window.yterr&&"function"===typeof window.yterr&&window.yterr(e);f=0===e.sampleWeight;if(!Ah.has(e.message)&&!f){"ERROR"===d?(uh.J("handleError",e),T("record_app_crashed_web")&&0===Dh&&1===e.sampleWeight&&(Dh++,ph("appCrashed",{appCrashType:"APP_CRASH_TYPE_BREAKPAD"})),Ch++):"WARNING"===d&&uh.J("handleWarning",e);if(T("kevlar_gel_error_routing")){h=d;g=e;a:{f=
u(Fh);for(m=f.next();!m.done;m=f.next())if((n=gb)&&0<=n.toLowerCase().indexOf(m.value.toLowerCase())){f=!0;break a}f=!1}if(!f){m={stackTrace:g.stack};g.fileName&&(m.filename=g.fileName);f=g.lineNumber&&g.lineNumber.split?g.lineNumber.split(":"):[];0!==f.length&&(1!==f.length||isNaN(Number(f[0]))?2!==f.length||isNaN(Number(f[0]))||isNaN(Number(f[1]))||(m.lineNumber=Number(f[0]),m.columnNumber=Number(f[1])):m.lineNumber=Number(f[0]));f={level:"ERROR_LEVEL_UNKNOWN",message:g.message,errorClassName:g.name,
sampleWeight:g.sampleWeight};"ERROR"===h?f.level="ERROR_LEVEL_ERROR":"WARNING"===h&&(f.level="ERROR_LEVEL_WARNNING");h={isObfuscated:!0,browserStackInfo:m};m={pageUrl:window.location.href,kvPairs:[]};R("FEXP_EXPERIMENTS")&&(m.experimentIds=R("FEXP_EXPERIMENTS"));if(g=g.params)for(n=u(Object.keys(g)),k=n.next();!k.done;k=n.next())k=k.value,m.kvPairs.push({key:"client."+k,value:String(g[k])});g=R("SERVER_NAME",void 0);n=R("SERVER_VERSION",void 0);g&&n&&(m.kvPairs.push({key:"server.name",value:g}),m.kvPairs.push({key:"server.version",
value:n}));ph("clientError",{errorMetadata:m,stackTrace:h,logMessage:f});Qf()}}if(!T("suppress_error_204_logging")){g=e;f=g.params||{};d={urlParams:{a:"logerror",t:"jserror",type:g.name,msg:g.message.substr(0,250),line:g.lineNumber,level:d,"client.name":f.name},postParams:{url:R("PAGE_NAME",window.location.href),file:g.fileName},method:"POST"};f.version&&(d["client.version"]=f.version);if(d.postParams){g.stack&&(d.postParams.stack=g.stack);g=u(Object.keys(f));for(h=g.next();!h.done;h=g.next())h=h.value,
d.postParams["client."+h]=f[h];if(f=R("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0))for(g=u(Object.keys(f)),h=g.next();!h.done;h=g.next())h=h.value,d.postParams[h]=f[h];f=R("SERVER_NAME",void 0);g=R("SERVER_VERSION",void 0);f&&g&&(d.postParams["server.name"]=f,d.postParams["server.version"]=g)}mf(R("ECATCHER_REPORT_HOST","")+"/error_204",d)}Ah.add(e.message);Bh++}}}}}else throw D;}else console&&console.warn&&console.warn("The YouTube player is not attached to the DOM. API calls should be made after the onReady event. See more: https://developers.google.com/youtube/iframe_api_reference#Events")};function Mh(a){return(0===a.search("cue")||0===a.search("load"))&&"loadModule"!==a}
function Nh(a){return 0===a.search("get")||0===a.search("is")}
;function Z(a,b){if(!a)throw Error("YouTube player element ID required.");var c={title:"video player",videoId:"",width:640,height:360};if(b)for(var d in b)c[d]=b[d];Y.call(this,a,c,"player");this.G={};this.playerInfo={}}
y(Z,Y);r=Z.prototype;r.W=function(){var a=S(this.i,"playerVars");if(a){var b={},c;for(c in a)b[c]=a[c];a=b}else a={};window!=window.top&&document.referrer&&(a.widget_referrer=document.referrer.substring(0,256));if(c=S(this.i,"embedConfig")){if(F(c))try{c=JSON.stringify(c)}catch(d){console.error("Invalid embed config JSON",d)}a.embed_config=c}return a};
r.ba=function(a){var b=a.event;a=a.info;switch(b){case "apiInfoDelivery":if(F(a))for(var c in a)this.G[c]=a[c];break;case "infoDelivery":Oh(this,a);break;case "initialDelivery":window.clearInterval(this.j);this.playerInfo={};this.G={};Ph(this,a.apiInterface);Oh(this,a);break;default:Jh(this,b,a)}};
function Oh(a,b){if(F(b))for(var c in b)a.playerInfo[c]=b[c]}
function Ph(a,b){J(b,function(c){this[c]||("getCurrentTime"==c?this[c]=function(){var d=this.playerInfo.currentTime;if(1==this.playerInfo.playerState){var e=(Date.now()/1E3-this.playerInfo.currentTimeLastUpdated_)*this.playerInfo.playbackRate;0<e&&(d+=Math.min(e,1))}return d}:Mh(c)?this[c]=function(){this.playerInfo={};
this.G={};Lh(this,c,arguments);return this}:Nh(c)?this[c]=function(){var d=0;
0===c.search("get")?d=3:0===c.search("is")&&(d=2);return this.playerInfo[c.charAt(d).toLowerCase()+c.substr(d+1)]}:this[c]=function(){Lh(this,c,arguments);
return this})},a)}
r.getVideoEmbedCode=function(){var a=parseInt(S(this.i,"width"),10),b=parseInt(S(this.i,"height"),10),c=S(this.i,"host")+("/embed/"+S(this.i,"videoId"));fb.test(c)&&(-1!=c.indexOf("&")&&(c=c.replace($a,"&amp;")),-1!=c.indexOf("<")&&(c=c.replace(ab,"&lt;")),-1!=c.indexOf(">")&&(c=c.replace(bb,"&gt;")),-1!=c.indexOf('"')&&(c=c.replace(cb,"&quot;")),-1!=c.indexOf("'")&&(c=c.replace(db,"&#39;")),-1!=c.indexOf("\x00")&&(c=c.replace(eb,"&#0;")));return'<iframe width="'+a+'" height="'+b+'" src="'+c+'" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'};
r.getOptions=function(a){return this.G.namespaces?a?this.G[a].options||[]:this.G.namespaces||[]:[]};
r.getOption=function(a,b){if(this.G.namespaces&&a&&b)return this.G[a][b]};
function Qh(a){if("iframe"!=a.tagName.toLowerCase()){var b=Oe(a,"videoid");b&&(b={videoId:b,width:Oe(a,"width"),height:Oe(a,"height")},new Z(a,b))}}
;H("YT.PlayerState.UNSTARTED",-1);H("YT.PlayerState.ENDED",0);H("YT.PlayerState.PLAYING",1);H("YT.PlayerState.PAUSED",2);H("YT.PlayerState.BUFFERING",3);H("YT.PlayerState.CUED",5);H("YT.get",function(a){return Ke[a]});
H("YT.scan",Ne);H("YT.subscribe",function(a,b,c){Td.subscribe(a,b,c);Me[a]=!0;for(var d in Ke)Ih(Ke[d],a)});
H("YT.unsubscribe",function(a,b,c){Sd(a,b,c)});
H("YT.Player",Z);Y.prototype.destroy=Y.prototype.destroy;Y.prototype.setSize=Y.prototype.setSize;Y.prototype.getIframe=Y.prototype.ia;Y.prototype.addEventListener=Y.prototype.addEventListener;Z.prototype.getVideoEmbedCode=Z.prototype.getVideoEmbedCode;Z.prototype.getOptions=Z.prototype.getOptions;Z.prototype.getOption=Z.prototype.getOption;
Le.push(function(a){var b=a;b||(b=document);a=Pa(b.getElementsByTagName("yt:player"));var c=b||document;if(c.querySelectorAll&&c.querySelector)b=c.querySelectorAll(".yt-player");else{var d;c=document;b=b||c;if(b.querySelectorAll&&b.querySelector)b=b.querySelectorAll(".yt-player");else if(b.getElementsByClassName){var e=b.getElementsByClassName("yt-player");b=e}else{e=b.getElementsByTagName("*");var f={};for(c=d=0;b=e[c];c++){var g=b.className,h;if(h="function"==typeof g.split)h=0<=Ka(g.split(/\s+/),
"yt-player");h&&(f[d++]=b)}f.length=d;b=f}}b=Pa(b);J(Oa(a,b),Qh)});
"undefined"!=typeof YTConfig&&YTConfig.parsetags&&"onload"!=YTConfig.parsetags||Ne();var Rh=C.onYTReady;Rh&&Rh();var Sh=C.onYouTubeIframeAPIReady;Sh&&Sh();var Th=C.onYouTubePlayerAPIReady;Th&&Th();}).call(this);
