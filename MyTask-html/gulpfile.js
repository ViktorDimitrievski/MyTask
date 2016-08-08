var gulp = require("gulp");
var config = require("./gulp.config")();
var concat = require("gulp-concat");
var concatCss = require("gulp-concat-css");
var minify = require("gulp-minify");
var minifyCss = require("gulp-minify-css");
var watch = require("gulp-watch");
var sass = require("gulp-sass");
var runSequence = require("run-sequence");
var plumber = require("gulp-plumber");
var del = require("del");
var merge = require("merge-stream");
var less = require("gulp-less");

gulp.task("default", ["build"], function () { });


gulp.task("build", function () {
    runSequence(
        "clean",
        ["styles", "styles-libraries", "scripts-libraries", "scripts","fonts"],
        function () {
            console.log("**** Success ******");
        });
});

// watch 
gulp.task("watch", function () {
    gulp.run("build");

    watch(config.allScss, function () {
        gulp.run("styles");
    });


});

gulp.task("scripts", function () {
    return gulp.src(config.path.src + "main.js")
    .pipe(plumber())
    .pipe(concat("bundle.js"))
    .pipe(gulp.dest(config.path.dist + "/js"));
});

gulp.task("scripts-libraries", function () {
    return gulp.src([
            "./node_modules/jquery/dist/jquery.min.js",
            "./node_modules/bootstrap/dist/js/bootstrap.min.js",
			"./node_modules/bootstrap-material-design/dist/js/material.min.js",
			"./node_modules/bootstrap-material-design/dist/js/ripples.min.js"
    ])
        .pipe(plumber())
        .pipe(concat("bundle.libraries.js"))
        .pipe(gulp.dest(config.path.dist + "/js"));
});


gulp.task("styles-libraries", function () {

    return gulp.src([
         "./node_modules/bootstrap/dist/css/bootstrap.min.css",
         "./node_modules/bootstrap-material-design/dist/css/bootstrap-material-design.min.css",
         "./node_modules/bootstrap-material-design/dist/css/ripples.min.css",
         "./node_modules/font-awesome/css/font-awesome.min.css"
    ])
         .pipe(plumber())
         .pipe(concatCss("bundle-libraries.css"))
         .pipe(gulp.dest(config.path.dist + "/css"));
});

gulp.task("styles", function () {

    return gulp.src(config.path.src + "main.scss")
       .pipe(plumber())
       .pipe(sass())
       .pipe(concatCss("bundle.css"))
       .pipe(gulp.dest(config.path.dist + "/css"));

});

gulp.task("fonts", function () {
    return gulp
        .src("./node_modules/font-awesome/fonts/**/*")
        .pipe(gulp.dest(config.path.dist + "/fonts"));
});

gulp.task("clean", function (cb) {
    var files = [
        config.path.dist + "**/*.js",
        config.path.dist + "**/*.js.map",
        config.path.dist + "**/*.css"
    ];
    return del(files, cb);
});