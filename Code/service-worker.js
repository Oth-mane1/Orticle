const CACHE_NAME = "OrticleV11";

const cache = async (request, response) => {
    if (response.type === "error" || response.type === "opaque") {
        return Promise.resolve(); // do not put in cache network errors
    }

    const cache = await caches
        .open(CACHE_NAME);
    return await cache.put(request, response.clone());
}

self.addEventListener("activate", event => {
    // delete any unexpected caches
    event.waitUntil(
        caches
            .keys()
            .then(keys => keys.filter(key => key !== CACHE_NAME))
            .then(keys =>
                Promise.all(
                    keys.map(key => {
                        console.info(`Deleting cache ${key}`);
                        return caches.delete(key);
                    })
                )
            )
    );
});

self.addEventListener("fetch", event => {
    // Do not look in the chache if the method isn't GET
    if (event.request.method != 'GET') {
        return console.error('Method unsupported')
    }

    // Request pages with /app from the server not from the cache
    if (event.request.url.includes("/app/") && !event.request.url.includes("/images/app/")) {
        return console.error('Response with a request')
    }

    // Cache-First Strategy
    event.respondWith(
        caches
            .match(event.request) // check if the request has already been cached
            .then(cached => cached || fetch(event.request)) // otherwise request network
            .then(
                response =>
                    cache(event.request, response) // put response in cache
                        .then(() => response) // resolve promise with the network response
            )
    );
});