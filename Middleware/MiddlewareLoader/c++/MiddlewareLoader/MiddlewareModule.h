//
// Created by Marcos on 04/08/2021.
//

#ifndef MIDDLEWARELOADER_MIDDLEWAREMODULE_H
#define MIDDLEWARELOADER_MIDDLEWAREMODULE_H
#include <map>
#include <iostream>

class MiddlewareModule {
public:
    /**
     * Default Args ServerMode List;
     * TEXT:TYPE
     * Server:(AsyncServer*)
     * Client:(ServerClient*)
     */
    MiddlewareModule(void (*ServerMain)(std::map<std::string, void *> &Args) = NULL, void (*ClientMain)(std::map<std::string, void *> &)= NULL );
    void (*ServerMain)(std::map<std::string,void*>&) = NULL;
    void (*ClientMain)(std::map<std::string,void*>&) = NULL;
    int priority;
    bool operator< (MiddlewareModule check);
private:

};


#endif //MIDDLEWARELOADER_MIDDLEWAREMODULE_H
