!function(e){var n={};function t(r){if(n[r])return n[r].exports;var o=n[r]={i:r,l:!1,exports:{}};return e[r].call(o.exports,o,o.exports,t),o.l=!0,o.exports}t.m=e,t.c=n,t.d=function(e,n,r){t.o(e,n)||Object.defineProperty(e,n,{enumerable:!0,get:r})},t.r=function(e){"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},t.t=function(e,n){if(1&n&&(e=t(e)),8&n)return e;if(4&n&&"object"==typeof e&&e&&e.__esModule)return e;var r=Object.create(null);if(t.r(r),Object.defineProperty(r,"default",{enumerable:!0,value:e}),2&n&&"string"!=typeof e)for(var o in e)t.d(r,o,function(n){return e[n]}.bind(null,o));return r},t.n=function(e){var n=e&&e.__esModule?function(){return e.default}:function(){return e};return t.d(n,"a",n),n},t.o=function(e,n){return Object.prototype.hasOwnProperty.call(e,n)},t.p="/dist/",t(t.s=1)}([function(e,n,t){"use strict";
/*! Agility
*/var r=new function(){var e=this;e.RegisterNamespace=function(e){for(var n=e.split("."),t=window,r=0;r<n.length;r++)t=void 0===t[n[r]]?t[n[r]]={}:t[n[r]];return t};var n=null;e.SessionLevelCacheKey=function(){return null==n&&(n=(new Date).toString("yyyyMMddHHmmss")),n};var t={},r=0;e.UniqueID=function(e){return null==e||null==e||""==e?r++:(null==t[e]&&(t[e]=0),e+t[e]++)},e.CloneObject=function(e){return JSON.parse(JSON.stringify(e))},e.ResolveUrl=function(e){var n=window.Agility_BaseUrl||"/";return e.replace(/^~\//,n)},e.QueryString=function(e,n){null!=n&&null!=n&&""!=n||(n=location.href);var t=n.indexOf("?");if(t<1&&t==n.length-2)return null;-1!=n.indexOf("#")&&(n=n.substring(0,n.indexOf("#")));var r=n.substring(t+1,n.length).split("&"),o=null;for(var i in r){var u=r[i].split("=");if(2==u.length&&unescape(u[0]).toLowerCase()==e.toLowerCase())return o=(o=u[1]).replace(/\+/g,"%20"),o=unescape(o),!1}return o},e.SetCookie=function(e,n,t,r,o,i){var u=t;document.cookie=e+"="+escape(n)+(t?";expires="+u.toGMTString():"")+(r?";path="+r:"")+(o?";domain="+o:"")+(i?";secure":"")},e.GetCookie=function(e){var n=document.cookie.split(";"),t="",r="",o=!1;for(i=0;i<n.length;i++){if((t=n[i].split("="))[0].replace(/^\s+|\s+$/g,"")==e)return o=!0,t.length>1&&(r=unescape(t[1].replace(/^\s+|\s+$/g,""))),r;t=null,""}if(!o)return null},e.DeleteCookie=function(n,t,r,o){e.GetCookie(n)&&(document.cookie=n+"="+(t?";path="+t:"")+(r?";domain="+r:"")+(o?";secure":"")+";expires=Thu, 01-Jan-1970 00:00:01 GMT")}};e.exports=r},function(e,n,t){"use strict";t.r(n);t(2);var r=t(0),o=t.n(r);document.getElementById("test").onclick=function(){alert("hello "+o.a.UniqueID("fromAgilityNPM-"))}},function(e,n,t){}]);
//# sourceMappingURL=main.js.map