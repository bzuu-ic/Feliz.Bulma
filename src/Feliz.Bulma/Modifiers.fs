namespace Feliz.Bulma

open System

module private ClassLiterals =
    let [<Literal>] ``is-clearfix`` = "is-clearfix"
    let [<Literal>] ``is-pulled-left`` = "is-pulled-left"
    let [<Literal>] ``is-pulled-right`` = "is-pulled-right"
    let [<Literal>] ``is-marginless`` = "is-marginless"
    let [<Literal>] ``is-paddingless`` = "is-paddingless"
    let [<Literal>] ``is-overlay`` = "is-overlay"
    let [<Literal>] ``is-clipped`` = "is-clipped"
    let [<Literal>] ``is-radiusless`` = "is-radiusless"
    let [<Literal>] ``is-shadowless`` = "is-shadowless"
    let [<Literal>] ``is-unselectable`` = "is-unselectable"
    let [<Literal>] ``is-invisible`` = "is-invisible"
    let [<Literal>] ``is-hidden`` = "is-hidden"
    let [<Literal>] ``is-sr-only`` = "is-sr-only"
    let [<Literal>] ``is-relative`` = "is-relative"
    let [<Literal>] ``is-block`` = "is-block"
    let [<Literal>] ``is-flex`` = "is-flex"
    let [<Literal>] ``is-inline`` = "is-inline"
    let [<Literal>] ``is-inline-block`` = "is-inline-block"
    let [<Literal>] ``is-inline-flex`` = "is-inline-flex"
    let [<Literal>] ``is-size-1`` = "is-size-1"
    let [<Literal>] ``is-size-2`` = "is-size-2"
    let [<Literal>] ``is-size-3`` = "is-size-3"
    let [<Literal>] ``is-size-4`` = "is-size-4"
    let [<Literal>] ``is-size-5`` = "is-size-5"
    let [<Literal>] ``is-size-6`` = "is-size-6"
    let [<Literal>] ``is-size-7`` = "is-size-7"
    let [<Literal>] ``is-size-1-mobile`` = "is-size-1-mobile"
    let [<Literal>] ``is-size-2-mobile`` = "is-size-2-mobile"
    let [<Literal>] ``is-size-3-mobile`` = "is-size-3-mobile"
    let [<Literal>] ``is-size-4-mobile`` = "is-size-4-mobile"
    let [<Literal>] ``is-size-5-mobile`` = "is-size-5-mobile"
    let [<Literal>] ``is-size-6-mobile`` = "is-size-6-mobile"
    let [<Literal>] ``is-size-7-mobile`` = "is-size-7-mobile"
    let [<Literal>] ``is-size-1-tablet`` = "is-size-1-tablet"
    let [<Literal>] ``is-size-2-tablet`` = "is-size-2-tablet"
    let [<Literal>] ``is-size-3-tablet`` = "is-size-3-tablet"
    let [<Literal>] ``is-size-4-tablet`` = "is-size-4-tablet"
    let [<Literal>] ``is-size-5-tablet`` = "is-size-5-tablet"
    let [<Literal>] ``is-size-6-tablet`` = "is-size-6-tablet"
    let [<Literal>] ``is-size-7-tablet`` = "is-size-7-tablet"
    let [<Literal>] ``is-size-1-touch`` = "is-size-1-touch"
    let [<Literal>] ``is-size-2-touch`` = "is-size-2-touch"
    let [<Literal>] ``is-size-3-touch`` = "is-size-3-touch"
    let [<Literal>] ``is-size-4-touch`` = "is-size-4-touch"
    let [<Literal>] ``is-size-5-touch`` = "is-size-5-touch"
    let [<Literal>] ``is-size-6-touch`` = "is-size-6-touch"
    let [<Literal>] ``is-size-7-touch`` = "is-size-7-touch"
    let [<Literal>] ``is-size-1-desktop`` = "is-size-1-desktop"
    let [<Literal>] ``is-size-2-desktop`` = "is-size-2-desktop"
    let [<Literal>] ``is-size-3-desktop`` = "is-size-3-desktop"
    let [<Literal>] ``is-size-4-desktop`` = "is-size-4-desktop"
    let [<Literal>] ``is-size-5-desktop`` = "is-size-5-desktop"
    let [<Literal>] ``is-size-6-desktop`` = "is-size-6-desktop"
    let [<Literal>] ``is-size-7-desktop`` = "is-size-7-desktop"
    let [<Literal>] ``is-size-1-widescreen`` = "is-size-1-widescreen"
    let [<Literal>] ``is-size-2-widescreen`` = "is-size-2-widescreen"
    let [<Literal>] ``is-size-3-widescreen`` = "is-size-3-widescreen"
    let [<Literal>] ``is-size-4-widescreen`` = "is-size-4-widescreen"
    let [<Literal>] ``is-size-5-widescreen`` = "is-size-5-widescreen"
    let [<Literal>] ``is-size-6-widescreen`` = "is-size-6-widescreen"
    let [<Literal>] ``is-size-7-widescreen`` = "is-size-7-widescreen"
    let [<Literal>] ``is-size-1-fullhd`` = "is-size-1-fullhd"
    let [<Literal>] ``is-size-2-fullhd`` = "is-size-2-fullhd"
    let [<Literal>] ``is-size-3-fullhd`` = "is-size-3-fullhd"
    let [<Literal>] ``is-size-4-fullhd`` = "is-size-4-fullhd"
    let [<Literal>] ``is-size-5-fullhd`` = "is-size-5-fullhd"
    let [<Literal>] ``is-size-6-fullhd`` = "is-size-6-fullhd"
    let [<Literal>] ``is-size-7-fullhd`` = "is-size-7-fullhd"
    let [<Literal>] ``is-family-sans-serif`` = "is-family-sans-serif"
    let [<Literal>] ``is-family-monospace`` = "is-family-monospace"
    let [<Literal>] ``is-family-primary`` = "is-family-primary"
    let [<Literal>] ``is-family-secondary`` = "is-family-secondary"
    let [<Literal>] ``is-family-code`` = "is-family-code"
    let [<Literal>] ``is-capitalized`` = "is-capitalized"
    let [<Literal>] ``is-lowercase`` = "is-lowercase"
    let [<Literal>] ``is-uppercase`` = "is-uppercase"
    let [<Literal>] ``is-italic`` = "is-italic"
    let [<Literal>] ``has-text-weight-light`` = "has-text-weight-light"
    let [<Literal>] ``has-text-weight-normal`` = "has-text-weight-normal"
    let [<Literal>] ``has-text-weight-medium`` = "has-text-weight-medium"
    let [<Literal>] ``has-text-weight-semibold`` = "has-text-weight-semibold"
    let [<Literal>] ``has-text-weight-bold`` = "has-text-weight-bold"
    let [<Literal>] ``has-text-centered`` = "has-text-centered"
    let [<Literal>] ``has-text-justified`` = "has-text-justified"
    let [<Literal>] ``has-text-left`` = "has-text-left"
    let [<Literal>] ``has-text-right`` = "has-text-right"
    let [<Literal>] ``has-text-centered-mobile`` = "has-text-centered-mobile"
    let [<Literal>] ``has-text-justified-mobile`` = "has-text-justified-mobile"
    let [<Literal>] ``has-text-left-mobile`` = "has-text-left-mobile"
    let [<Literal>] ``has-text-right-mobile`` = "has-text-right-mobile"
    let [<Literal>] ``has-text-centered-tablet`` = "has-text-centered-tablet"
    let [<Literal>] ``has-text-justified-tablet`` = "has-text-justified-tablet"
    let [<Literal>] ``has-text-left-tablet`` = "has-text-left-tablet"
    let [<Literal>] ``has-text-right-tablet`` = "has-text-right-tablet"
    let [<Literal>] ``has-text-centered-tablet-only`` = "has-text-centered-tablet-only"
    let [<Literal>] ``has-text-justified-tablet-only`` = "has-text-justified-tablet-only"
    let [<Literal>] ``has-text-left-tablet-only`` = "has-text-left-tablet-only"
    let [<Literal>] ``has-text-right-tablet-only`` = "has-text-right-tablet-only"
    let [<Literal>] ``has-text-centered-touch`` = "has-text-centered-touch"
    let [<Literal>] ``has-text-justified-touch`` = "has-text-justified-touch"
    let [<Literal>] ``has-text-left-touch`` = "has-text-left-touch"
    let [<Literal>] ``has-text-right-touch`` = "has-text-right-touch"
    let [<Literal>] ``has-text-centered-desktop`` = "has-text-centered-desktop"
    let [<Literal>] ``has-text-justified-desktop`` = "has-text-justified-desktop"
    let [<Literal>] ``has-text-left-desktop`` = "has-text-left-desktop"
    let [<Literal>] ``has-text-right-desktop`` = "has-text-right-desktop"
    let [<Literal>] ``has-text-centered-desktop-only`` = "has-text-centered-desktop-only"
    let [<Literal>] ``has-text-justified-desktop-only`` = "has-text-justified-desktop-only"
    let [<Literal>] ``has-text-left-desktop-only`` = "has-text-left-desktop-only"
    let [<Literal>] ``has-text-right-desktop-only`` = "has-text-right-desktop-only"
    let [<Literal>] ``has-text-centered-widescreen`` = "has-text-centered-widescreen"
    let [<Literal>] ``has-text-justified-widescreen`` = "has-text-justified-widescreen"
    let [<Literal>] ``has-text-left-widescreen`` = "has-text-left-widescreen"
    let [<Literal>] ``has-text-right-widescreen`` = "has-text-right-widescreen"
    let [<Literal>] ``has-text-centered-widescreen-only`` = "has-text-centered-widescreen-only"
    let [<Literal>] ``has-text-justified-widescreen-only`` = "has-text-justified-widescreen-only"
    let [<Literal>] ``has-text-left-widescreen-only`` = "has-text-left-widescreen-only"
    let [<Literal>] ``has-text-right-widescreen-only`` = "has-text-right-widescreen-only"
    let [<Literal>] ``has-text-centered-fullhd`` = "has-text-centered-fullhd"
    let [<Literal>] ``has-text-justified-fullhd`` = "has-text-justified-fullhd"
    let [<Literal>] ``has-text-left-fullhd`` = "has-text-left-fullhd"
    let [<Literal>] ``has-text-right-fullhd`` = "has-text-right-fullhd"
    let [<Literal>] ``is-white`` = "is-white"
    let [<Literal>] ``is-black`` = "is-black"
    let [<Literal>] ``is-light`` = "is-light"
    let [<Literal>] ``is-dark`` = "is-dark"
    let [<Literal>] ``is-primary`` = "is-primary"
    let [<Literal>] ``is-link`` = "is-link"
    let [<Literal>] ``is-info`` = "is-info"
    let [<Literal>] ``is-success`` = "is-success"
    let [<Literal>] ``is-warning`` = "is-warning"
    let [<Literal>] ``is-danger`` = "is-danger"
    let [<Literal>] ``is-text`` = "is-text"
    let [<Literal>] ``has-text-white`` = "has-text-white"
    let [<Literal>] ``has-text-black`` = "has-text-black"
    let [<Literal>] ``has-text-light`` = "has-text-light"
    let [<Literal>] ``has-text-dark`` = "has-text-dark"
    let [<Literal>] ``has-text-primary`` = "has-text-primary"
    let [<Literal>] ``has-text-info`` = "has-text-info"
    let [<Literal>] ``has-text-link`` = "has-text-link"
    let [<Literal>] ``has-text-success`` = "has-text-success"
    let [<Literal>] ``has-text-warning`` = "has-text-warning"
    let [<Literal>] ``has-text-danger`` = "has-text-danger"
    let [<Literal>] ``has-text-black-bis`` = "has-text-black-bis"
    let [<Literal>] ``has-text-black-ter`` = "has-text-black-ter"
    let [<Literal>] ``has-text-grey-darker`` = "has-text-grey-darker"
    let [<Literal>] ``has-text-grey-dark`` = "has-text-grey-dark"
    let [<Literal>] ``has-text-grey`` = "has-text-grey"
    let [<Literal>] ``has-text-grey-light`` = "has-text-grey-light"
    let [<Literal>] ``has-text-grey-lighter`` = "has-text-grey-lighter"
    let [<Literal>] ``has-text-white-ter`` = "has-text-white-ter"
    let [<Literal>] ``has-text-white-bis`` = "has-text-white-bis"
    let [<Literal>] ``has-background-white`` = "has-background-white"
    let [<Literal>] ``has-background-black`` = "has-background-black"
    let [<Literal>] ``has-background-light`` = "has-background-light"
    let [<Literal>] ``has-background-dark`` = "has-background-dark"
    let [<Literal>] ``has-background-primary`` = "has-background-primary"
    let [<Literal>] ``has-background-info`` = "has-background-info"
    let [<Literal>] ``has-background-link`` = "has-background-link"
    let [<Literal>] ``has-background-success`` = "has-background-success"
    let [<Literal>] ``has-background-warning`` = "has-background-warning"
    let [<Literal>] ``has-background-danger`` = "has-background-danger"
    let [<Literal>] ``has-background-black-bis`` = "has-background-black-bis"
    let [<Literal>] ``has-background-black-ter`` = "has-background-black-ter"
    let [<Literal>] ``has-background-grey-darker`` = "has-background-grey-darker"
    let [<Literal>] ``has-background-grey-dark`` = "has-background-grey-dark"
    let [<Literal>] ``has-background-grey`` = "has-background-grey"
    let [<Literal>] ``has-background-grey-light`` = "has-background-grey-light"
    let [<Literal>] ``has-background-grey-lighter`` = "has-background-grey-lighter"
    let [<Literal>] ``has-background-white-ter`` = "has-background-white-ter"
    let [<Literal>] ``has-background-white-bis`` = "has-background-white-bis"
    let [<Literal>] ``is-16x16`` = "is-16x16"
    let [<Literal>] ``is-24x24`` = "is-24x24"
    let [<Literal>] ``is-32x32`` = "is-32x32"
    let [<Literal>] ``is-48x48`` = "is-48x48"
    let [<Literal>] ``is-64x64`` = "is-64x64"
    let [<Literal>] ``is-96x96`` = "is-96x96"
    let [<Literal>] ``is-128x128`` = "is-128x128"
    let [<Literal>] ``is-rounded`` = "is-rounded"
    let [<Literal>] ``is-square`` = "is-square"
    let [<Literal>] ``is-1by1`` = "is-1by1"
    let [<Literal>] ``is-5by4`` = "is-5by4"
    let [<Literal>] ``is-4by3`` = "is-4by3"
    let [<Literal>] ``is-3by2`` = "is-3by2"
    let [<Literal>] ``is-5by3`` = "is-5by3"
    let [<Literal>] ``is-16by9`` = "is-16by9"
    let [<Literal>] ``is-2by1`` = "is-2by1"
    let [<Literal>] ``is-3by1`` = "is-3by1"
    let [<Literal>] ``is-4by5`` = "is-4by5"
    let [<Literal>] ``is-3by4`` = "is-3by4"
    let [<Literal>] ``is-2by3`` = "is-2by3"
    let [<Literal>] ``is-3by5`` = "is-3by5"
    let [<Literal>] ``is-9by16`` = "is-9by16"
    let [<Literal>] ``is-1by2`` = "is-1by2"
    let [<Literal>] ``is-1by3`` = "is-1by3"
    let [<Literal>] ``is-fullwidth`` = "is-fullwidth"
    let [<Literal>] ``has-ratio`` = "has-ratio"
    let [<Literal>] ``is-bordered`` = "is-bordered"
    let [<Literal>] ``is-striped`` = "is-striped"
    let [<Literal>] ``is-narrow`` = "is-narrow"
    let [<Literal>] ``is-hoverable`` = "is-hoverable"
    let [<Literal>] ``is-selected`` = "is-selected"
    let [<Literal>] ``is-normal`` = "is-normal"
    let [<Literal>] ``is-medium`` = "is-medium"
    let [<Literal>] ``is-large`` = "is-large"
    let [<Literal>] ``is-delete`` = "is-delete"
    let [<Literal>] ``are-small`` = "are-small"
    let [<Literal>] ``are-medium`` = "are-medium"
    let [<Literal>] ``are-large`` = "are-large"
    let [<Literal>] ``has-addons`` = "has-addons"
    let [<Literal>] ``is-spaced`` = "is-spaced"
    let [<Literal>] ``is-centered`` = "is-centered"
    let [<Literal>] ``is-right`` = "is-right"
    let [<Literal>] ``is-small`` = "is-small"
    let [<Literal>] ``is-boxed`` = "is-boxed"
    let [<Literal>] ``is-toggle`` = "is-toggle"
    let [<Literal>] ``is-toggle-rounded`` = "is-toggle-rounded"
    let [<Literal>] ``has-arrow-separator`` = "has-arrow-separator"
    let [<Literal>] ``has-bullet-separator`` = "has-bullet-separator"
    let [<Literal>] ``has-dot-separator`` = "has-dot-separator"
    let [<Literal>] ``has-succeeds-separator`` = "has-succeeds-separator"
    let [<Literal>] ``is-active`` = "is-active"
    let [<Literal>] ``is-up`` = "is-up"
    let [<Literal>] ``is-transparent`` = "is-transparent"
    let [<Literal>] ``has-shadow`` = "has-shadow"
    let [<Literal>] ``is-fixed-top`` = "is-fixed-top"
    let [<Literal>] ``is-fixed-bottom`` = "is-fixed-bottom"
    let [<Literal>] ``is-arrowless`` = "is-arrowless"
    let [<Literal>] ``is-expanded`` = "is-expanded"
    let [<Literal>] ``is-tab`` = "is-tab"
    let [<Literal>] ``has-dropdown`` = "has-dropdown"
    let [<Literal>] ``has-dropdown-up`` = "has-dropdown-up"
    let [<Literal>] ``is-current`` = "is-current"
    let [<Literal>] ``has-name`` = "has-name"
    let [<Literal>] ``is-hovered`` = "is-hovered"
    let [<Literal>] ``is-focused`` = "is-focused"
    let [<Literal>] ``is-static`` = "is-static"
    let [<Literal>] ``is-outlined`` = "is-outlined"
    let [<Literal>] ``is-loading`` = "is-loading"
    let [<Literal>] ``is-inverted`` = "is-inverted"
    let [<Literal>] ``has-fixed-size`` = "has-fixed-size"
    let [<Literal>] ``has-addons-right`` = "has-addons-right"
    let [<Literal>] ``has-addons-centered`` = "has-addons-centered"
    let [<Literal>] ``is-grouped`` = "is-grouped"
    let [<Literal>] ``is-grouped-right`` = "is-grouped-right"
    let [<Literal>] ``is-grouped-centered`` = "is-grouped-centered"
    let [<Literal>] ``is-grouped-multiline`` = "is-grouped-multiline"
    let [<Literal>] ``is-horizontal`` = "is-horizontal"
    let [<Literal>] ``is-left`` = "is-left"
    let [<Literal>] ``is-multiple`` = "is-multiple"
    let [<Literal>] ``has-icons-left`` = "has-icons-left"
    let [<Literal>] ``has-icons-right`` = "has-icons-right"
    let [<Literal>] ``is-lower-alpha`` = "is-lower-alpha"
    let [<Literal>] ``is-lower-roman`` = "is-lower-roman"
    let [<Literal>] ``is-upper-alpha`` = "is-upper-alpha"
    let [<Literal>] ``is-upper-roman`` = "is-upper-roman"
    let [<Literal>] ``is-fluid`` = "is-fluid"
    let [<Literal>] ``is-widescreen`` = "is-widescreen"
    let [<Literal>] ``is-fullhd`` = "is-fullhd"
    let [<Literal>] ``is-mobile`` = "is-mobile"
    let [<Literal>] ``is-bold`` = "is-bold"
    let [<Literal>] ``is-fullheight`` = "is-fullheight"
    let [<Literal>] ``is-fullheight-with-navbar`` = "is-fullheight-with-navbar"
    let [<Literal>] ``is-ancestor`` = "is-ancestor"
    let [<Literal>] ``is-parent`` = "is-parent"
    let [<Literal>] ``is-child`` = "is-child"
    let [<Literal>] ``is-vertical`` = "is-vertical"
    let [<Literal>] ``is-1`` = "is-1"
    let [<Literal>] ``is-2`` = "is-2"
    let [<Literal>] ``is-3`` = "is-3"
    let [<Literal>] ``is-4`` = "is-4"
    let [<Literal>] ``is-5`` = "is-5"
    let [<Literal>] ``is-6`` = "is-6"
    let [<Literal>] ``is-7`` = "is-7"
    let [<Literal>] ``is-8`` = "is-8"
    let [<Literal>] ``is-9`` = "is-9"
    let [<Literal>] ``is-10`` = "is-10"
    let [<Literal>] ``is-11`` = "is-11"
    let [<Literal>] ``is-12`` = "is-12"
    let [<Literal>] ``is-desktop`` = "is-desktop"
    let [<Literal>] ``is-three-quarters`` = "is-three-quarters"
    let [<Literal>] ``is-two-thirds`` = "is-two-thirds"
    let [<Literal>] ``is-half`` = "is-half"
    let [<Literal>] ``is-one-third`` = "is-one-third"
    let [<Literal>] ``is-one-quarter`` = "is-one-quarter"
    let [<Literal>] ``is-full`` = "is-full"
    let [<Literal>] ``is-four-fifths`` = "is-four-fifths"
    let [<Literal>] ``is-three-fifths`` = "is-three-fifths"
    let [<Literal>] ``is-two-fifths`` = "is-two-fifths"
    let [<Literal>] ``is-one-fifth`` = "is-one-fifth"
    let [<Literal>] ``is-narrow-mobile`` = "is-narrow-mobile"
    let [<Literal>] ``is-narrow-tablet`` = "is-narrow-tablet"
    let [<Literal>] ``is-narrow-touch`` = "is-narrow-touch"
    let [<Literal>] ``is-narrow-desktop`` = "is-narrow-desktop"
    let [<Literal>] ``is-narrow-widescreen`` = "is-narrow-widescreen"
    let [<Literal>] ``is-narrow-fullhd`` = "is-narrow-fullhd"
    let [<Literal>] ``is-offset-1`` = "is-offset-1"
    let [<Literal>] ``is-offset-2`` = "is-offset-2"
    let [<Literal>] ``is-offset-3`` = "is-offset-3"
    let [<Literal>] ``is-offset-4`` = "is-offset-4"
    let [<Literal>] ``is-offset-5`` = "is-offset-5"
    let [<Literal>] ``is-offset-6`` = "is-offset-6"
    let [<Literal>] ``is-offset-7`` = "is-offset-7"
    let [<Literal>] ``is-offset-8`` = "is-offset-8"
    let [<Literal>] ``is-offset-9`` = "is-offset-9"
    let [<Literal>] ``is-offset-10`` = "is-offset-10"
    let [<Literal>] ``is-offset-11`` = "is-offset-11"
    let [<Literal>] ``is-offset-12`` = "is-offset-12"
    let [<Literal>] ``is-offset-three-quarters`` = "is-offset-three-quarters"
    let [<Literal>] ``is-offset-two-thirds`` = "is-offset-two-thirds"
    let [<Literal>] ``is-offset-half`` = "is-offset-half"
    let [<Literal>] ``is-offset-one-third`` = "is-offset-one-third"
    let [<Literal>] ``is-offset-one-quarter`` = "is-offset-one-quarter"
    let [<Literal>] ``is-offset-full`` = "is-offset-full"
    let [<Literal>] ``is-offset-four-fifths`` = "is-offset-four-fifths"
    let [<Literal>] ``is-offset-three-fifths`` = "is-offset-three-fifths"
    let [<Literal>] ``is-offset-two-fifths`` = "is-offset-two-fifths"
    let [<Literal>] ``is-offset-one-fifth`` = "is-offset-one-fifth"
    let [<Literal>] ``is-three-quarters-mobile`` = "is-three-quarters-mobile"
    let [<Literal>] ``is-two-thirds-mobile`` = "is-two-thirds-mobile"
    let [<Literal>] ``is-half-mobile`` = "is-half-mobile"
    let [<Literal>] ``is-one-third-mobile`` = "is-one-third-mobile"
    let [<Literal>] ``is-one-quarter-mobile`` = "is-one-quarter-mobile"
    let [<Literal>] ``is-full-mobile`` = "is-full-mobile"
    let [<Literal>] ``is-four-fifths-mobile`` = "is-four-fifths-mobile"
    let [<Literal>] ``is-three-fifths-mobile`` = "is-three-fifths-mobile"
    let [<Literal>] ``is-two-fifths-mobile`` = "is-two-fifths-mobile"
    let [<Literal>] ``is-one-fifth-mobile`` = "is-one-fifth-mobile"
    let [<Literal>] ``is-three-quarters-tablet`` = "is-three-quarters-tablet"
    let [<Literal>] ``is-two-thirds-tablet`` = "is-two-thirds-tablet"
    let [<Literal>] ``is-half-tablet`` = "is-half-tablet"
    let [<Literal>] ``is-one-third-tablet`` = "is-one-third-tablet"
    let [<Literal>] ``is-one-quarter-tablet`` = "is-one-quarter-tablet"
    let [<Literal>] ``is-full-tablet`` = "is-full-tablet"
    let [<Literal>] ``is-four-fifths-tablet`` = "is-four-fifths-tablet"
    let [<Literal>] ``is-three-fifths-tablet`` = "is-three-fifths-tablet"
    let [<Literal>] ``is-two-fifths-tablet`` = "is-two-fifths-tablet"
    let [<Literal>] ``is-one-fifth-tablet`` = "is-one-fifth-tablet"
    let [<Literal>] ``is-three-quarters-desktop`` = "is-three-quarters-desktop"
    let [<Literal>] ``is-two-thirds-desktop`` = "is-two-thirds-desktop"
    let [<Literal>] ``is-half-desktop`` = "is-half-desktop"
    let [<Literal>] ``is-one-third-desktop`` = "is-one-third-desktop"
    let [<Literal>] ``is-one-quarter-desktop`` = "is-one-quarter-desktop"
    let [<Literal>] ``is-full-desktop`` = "is-full-desktop"
    let [<Literal>] ``is-four-fifths-desktop`` = "is-four-fifths-desktop"
    let [<Literal>] ``is-three-fifths-desktop`` = "is-three-fifths-desktop"
    let [<Literal>] ``is-two-fifths-desktop`` = "is-two-fifths-desktop"
    let [<Literal>] ``is-one-fifth-desktop`` = "is-one-fifth-desktop"
    let [<Literal>] ``is-three-quarters-widescreen`` = "is-three-quarters-widescreen"
    let [<Literal>] ``is-two-thirds-widescreen`` = "is-two-thirds-widescreen"
    let [<Literal>] ``is-half-widescreen`` = "is-half-widescreen"
    let [<Literal>] ``is-one-third-widescreen`` = "is-one-third-widescreen"
    let [<Literal>] ``is-one-quarter-widescreen`` = "is-one-quarter-widescreen"
    let [<Literal>] ``is-full-widescreen`` = "is-full-widescreen"
    let [<Literal>] ``is-four-fifths-widescreen`` = "is-four-fifths-widescreen"
    let [<Literal>] ``is-three-fifths-widescreen`` = "is-three-fifths-widescreen"
    let [<Literal>] ``is-two-fifths-widescreen`` = "is-two-fifths-widescreen"
    let [<Literal>] ``is-one-fifth-widescreen`` = "is-one-fifth-widescreen"
    let [<Literal>] ``is-three-quarters-fullhd`` = "is-three-quarters-fullhd"
    let [<Literal>] ``is-two-thirds-fullhd`` = "is-two-thirds-fullhd"
    let [<Literal>] ``is-half-fullhd`` = "is-half-fullhd"
    let [<Literal>] ``is-one-third-fullhd`` = "is-one-third-fullhd"
    let [<Literal>] ``is-one-quarter-fullhd`` = "is-one-quarter-fullhd"
    let [<Literal>] ``is-full-fullhd`` = "is-full-fullhd"
    let [<Literal>] ``is-four-fifths-fullhd`` = "is-four-fifths-fullhd"
    let [<Literal>] ``is-three-fifths-fullhd`` = "is-three-fifths-fullhd"
    let [<Literal>] ``is-two-fifths-fullhd`` = "is-two-fifths-fullhd"
    let [<Literal>] ``is-one-fifth-fullhd`` = "is-one-fifth-fullhd"
    let [<Literal>] ``is-gapless`` = "is-gapless"
    let [<Literal>] ``is-multiline`` = "is-multiline"
    let [<Literal>] ``is-variable`` = "is-variable"
    let [<Literal>] ``is-vcentered`` = "is-vcentered"
    let [<Literal>] ``mt-0`` = "mt-0"
    let [<Literal>] ``mt-1`` = "mt-1"
    let [<Literal>] ``mt-2`` = "mt-2"
    let [<Literal>] ``mt-3`` = "mt-3"
    let [<Literal>] ``mt-4`` = "mt-4"
    let [<Literal>] ``mt-5`` = "mt-5"
    let [<Literal>] ``mt-6`` = "mt-6"
    let [<Literal>] ``mr-0`` = "mr-0"
    let [<Literal>] ``mr-1`` = "mr-1"
    let [<Literal>] ``mr-2`` = "mr-2"
    let [<Literal>] ``mr-3`` = "mr-3"
    let [<Literal>] ``mr-4`` = "mr-4"
    let [<Literal>] ``mr-5`` = "mr-5"
    let [<Literal>] ``mr-6`` = "mr-6"
    let [<Literal>] ``mb-0`` = "mb-0"
    let [<Literal>] ``mb-1`` = "mb-1"
    let [<Literal>] ``mb-2`` = "mb-2"
    let [<Literal>] ``mb-3`` = "mb-3"
    let [<Literal>] ``mb-4`` = "mb-4"
    let [<Literal>] ``mb-5`` = "mb-5"
    let [<Literal>] ``mb-6`` = "mb-6"
    let [<Literal>] ``ml-0`` = "ml-0"
    let [<Literal>] ``ml-1`` = "ml-1"
    let [<Literal>] ``ml-2`` = "ml-2"
    let [<Literal>] ``ml-3`` = "ml-3"
    let [<Literal>] ``ml-4`` = "ml-4"
    let [<Literal>] ``ml-5`` = "ml-5"
    let [<Literal>] ``ml-6`` = "ml-6"
    let [<Literal>] ``mx-0`` = "mx-0"
    let [<Literal>] ``mx-1`` = "mx-1"
    let [<Literal>] ``mx-2`` = "mx-2"
    let [<Literal>] ``mx-3`` = "mx-3"
    let [<Literal>] ``mx-4`` = "mx-4"
    let [<Literal>] ``mx-5`` = "mx-5"
    let [<Literal>] ``mx-6`` = "mx-6"
    let [<Literal>] ``my-0`` = "my-0"
    let [<Literal>] ``my-1`` = "my-1"
    let [<Literal>] ``my-2`` = "my-2"
    let [<Literal>] ``my-3`` = "my-3"
    let [<Literal>] ``my-4`` = "my-4"
    let [<Literal>] ``my-5`` = "my-5"
    let [<Literal>] ``my-6`` = "my-6"
    let [<Literal>] ``pt-0`` = "pt-0"
    let [<Literal>] ``pt-1`` = "pt-1"
    let [<Literal>] ``pt-2`` = "pt-2"
    let [<Literal>] ``pt-3`` = "pt-3"
    let [<Literal>] ``pt-4`` = "pt-4"
    let [<Literal>] ``pt-5`` = "pt-5"
    let [<Literal>] ``pt-6`` = "pt-6"
    let [<Literal>] ``pr-0`` = "pr-0"
    let [<Literal>] ``pr-1`` = "pr-1"
    let [<Literal>] ``pr-2`` = "pr-2"
    let [<Literal>] ``pr-3`` = "pr-3"
    let [<Literal>] ``pr-4`` = "pr-4"
    let [<Literal>] ``pr-5`` = "pr-5"
    let [<Literal>] ``pr-6`` = "pr-6"
    let [<Literal>] ``pb-0`` = "pb-0"
    let [<Literal>] ``pb-1`` = "pb-1"
    let [<Literal>] ``pb-2`` = "pb-2"
    let [<Literal>] ``pb-3`` = "pb-3"
    let [<Literal>] ``pb-4`` = "pb-4"
    let [<Literal>] ``pb-5`` = "pb-5"
    let [<Literal>] ``pb-6`` = "pb-6"
    let [<Literal>] ``pl-0`` = "pl-0"
    let [<Literal>] ``pl-1`` = "pl-1"
    let [<Literal>] ``pl-2`` = "pl-2"
    let [<Literal>] ``pl-3`` = "pl-3"
    let [<Literal>] ``pl-4`` = "pl-4"
    let [<Literal>] ``pl-5`` = "pl-5"
    let [<Literal>] ``pl-6`` = "pl-6"
    let [<Literal>] ``px-0`` = "px-0"
    let [<Literal>] ``px-1`` = "px-1"
    let [<Literal>] ``px-2`` = "px-2"
    let [<Literal>] ``px-3`` = "px-3"
    let [<Literal>] ``px-4`` = "px-4"
    let [<Literal>] ``px-5`` = "px-5"
    let [<Literal>] ``px-6`` = "px-6"
    let [<Literal>] ``py-0`` = "py-0"
    let [<Literal>] ``py-1`` = "py-1"
    let [<Literal>] ``py-2`` = "py-2"
    let [<Literal>] ``py-3`` = "py-3"
    let [<Literal>] ``py-4`` = "py-4"
    let [<Literal>] ``py-5`` = "py-5"
    let [<Literal>] ``py-6`` = "py-6"

[<Fable.Core.Erase>]
type helpers =
    static member inline isClearfix = PropertyBuilders.mkClass ClassLiterals.``is-clearfix``
    static member inline isPulledLeft = PropertyBuilders.mkClass ClassLiterals.``is-pulled-left``
    static member inline isPulledRight = PropertyBuilders.mkClass ClassLiterals.``is-pulled-right``
    static member inline isMarginless = PropertyBuilders.mkClass ClassLiterals.``is-marginless``
    static member inline isPaddingless = PropertyBuilders.mkClass ClassLiterals.``is-paddingless``
    static member inline isOverlay = PropertyBuilders.mkClass ClassLiterals.``is-overlay``
    static member inline isClipped = PropertyBuilders.mkClass ClassLiterals.``is-clipped``
    static member inline isRadiusless = PropertyBuilders.mkClass ClassLiterals.``is-radiusless``
    static member inline isShadowless = PropertyBuilders.mkClass ClassLiterals.``is-shadowless``
    static member inline isUnselectable = PropertyBuilders.mkClass ClassLiterals.``is-unselectable``
    static member inline isInvisible = PropertyBuilders.mkClass ClassLiterals.``is-invisible``
    static member inline isHidden = PropertyBuilders.mkClass ClassLiterals.``is-hidden``
    static member inline isSrOnly = PropertyBuilders.mkClass ClassLiterals.``is-sr-only``
    static member inline isRelative = PropertyBuilders.mkClass ClassLiterals.``is-relative``
    static member inline isBlock = PropertyBuilders.mkClass ClassLiterals.``is-block``
    static member inline isFlex = PropertyBuilders.mkClass ClassLiterals.``is-flex``
    static member inline isInline = PropertyBuilders.mkClass ClassLiterals.``is-inline``
    static member inline isInlineBlock = PropertyBuilders.mkClass ClassLiterals.``is-inline-block``
    static member inline isInlineFlex = PropertyBuilders.mkClass ClassLiterals.``is-inline-flex``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type size =
    static member inline isSize1 = PropertyBuilders.mkClass ClassLiterals.``is-size-1``
    static member inline isSize2 = PropertyBuilders.mkClass ClassLiterals.``is-size-2``
    static member inline isSize3 = PropertyBuilders.mkClass ClassLiterals.``is-size-3``
    static member inline isSize4 = PropertyBuilders.mkClass ClassLiterals.``is-size-4``
    static member inline isSize5 = PropertyBuilders.mkClass ClassLiterals.``is-size-5``
    static member inline isSize6 = PropertyBuilders.mkClass ClassLiterals.``is-size-6``
    static member inline isSize7 = PropertyBuilders.mkClass ClassLiterals.``is-size-7``

    static member inline isSize1Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-1-mobile``
    static member inline isSize2Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-2-mobile``
    static member inline isSize3Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-3-mobile``
    static member inline isSize4Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-4-mobile``
    static member inline isSize5Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-5-mobile``
    static member inline isSize6Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-6-mobile``
    static member inline isSize7Mobile = PropertyBuilders.mkClass ClassLiterals.``is-size-7-mobile``

    static member inline isSize1Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-1-tablet``
    static member inline isSize2Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-2-tablet``
    static member inline isSize3Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-3-tablet``
    static member inline isSize4Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-4-tablet``
    static member inline isSize5Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-5-tablet``
    static member inline isSize6Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-6-tablet``
    static member inline isSize7Tablet = PropertyBuilders.mkClass ClassLiterals.``is-size-7-tablet``

    static member inline isSize1Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-1-touch``
    static member inline isSize2Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-2-touch``
    static member inline isSize3Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-3-touch``
    static member inline isSize4Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-4-touch``
    static member inline isSize5Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-5-touch``
    static member inline isSize6Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-6-touch``
    static member inline isSize7Touch = PropertyBuilders.mkClass ClassLiterals.``is-size-7-touch``

    static member inline isSize1Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-1-desktop``
    static member inline isSize2Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-2-desktop``
    static member inline isSize3Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-3-desktop``
    static member inline isSize4Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-4-desktop``
    static member inline isSize5Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-5-desktop``
    static member inline isSize6Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-6-desktop``
    static member inline isSize7Desktop = PropertyBuilders.mkClass ClassLiterals.``is-size-7-desktop``

    static member inline isSize1Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-1-widescreen``
    static member inline isSize2Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-2-widescreen``
    static member inline isSize3Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-3-widescreen``
    static member inline isSize4Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-4-widescreen``
    static member inline isSize5Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-5-widescreen``
    static member inline isSize6Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-6-widescreen``
    static member inline isSize7Widescreen = PropertyBuilders.mkClass ClassLiterals.``is-size-7-widescreen``

    static member inline isSize1FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-1-fullhd``
    static member inline isSize2FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-2-fullhd``
    static member inline isSize3FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-3-fullhd``
    static member inline isSize4FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-4-fullhd``
    static member inline isSize5FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-5-fullhd``
    static member inline isSize6FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-6-fullhd``
    static member inline isSize7FullHd = PropertyBuilders.mkClass ClassLiterals.``is-size-7-fullhd``

[<Fable.Core.Erase>]
type spacing =
    static member inline mt0 = PropertyBuilders.mkClass ClassLiterals.``mt-0``
    static member inline mt1 = PropertyBuilders.mkClass ClassLiterals.``mt-1``
    static member inline mt2 = PropertyBuilders.mkClass ClassLiterals.``mt-2``
    static member inline mt3 = PropertyBuilders.mkClass ClassLiterals.``mt-3``
    static member inline mt4 = PropertyBuilders.mkClass ClassLiterals.``mt-4``
    static member inline mt5 = PropertyBuilders.mkClass ClassLiterals.``mt-5``
    static member inline mt6 = PropertyBuilders.mkClass ClassLiterals.``mt-6``
    static member inline mr0 = PropertyBuilders.mkClass ClassLiterals.``mr-0``
    static member inline mr1 = PropertyBuilders.mkClass ClassLiterals.``mr-1``
    static member inline mr2 = PropertyBuilders.mkClass ClassLiterals.``mr-2``
    static member inline mr3 = PropertyBuilders.mkClass ClassLiterals.``mr-3``
    static member inline mr4 = PropertyBuilders.mkClass ClassLiterals.``mr-4``
    static member inline mr5 = PropertyBuilders.mkClass ClassLiterals.``mr-5``
    static member inline mr6 = PropertyBuilders.mkClass ClassLiterals.``mr-6``
    static member inline mb0 = PropertyBuilders.mkClass ClassLiterals.``mb-0``
    static member inline mb1 = PropertyBuilders.mkClass ClassLiterals.``mb-1``
    static member inline mb2 = PropertyBuilders.mkClass ClassLiterals.``mb-2``
    static member inline mb3 = PropertyBuilders.mkClass ClassLiterals.``mb-3``
    static member inline mb4 = PropertyBuilders.mkClass ClassLiterals.``mb-4``
    static member inline mb5 = PropertyBuilders.mkClass ClassLiterals.``mb-5``
    static member inline mb6 = PropertyBuilders.mkClass ClassLiterals.``mb-6``
    static member inline ml0 = PropertyBuilders.mkClass ClassLiterals.``ml-0``
    static member inline ml1 = PropertyBuilders.mkClass ClassLiterals.``ml-1``
    static member inline ml2 = PropertyBuilders.mkClass ClassLiterals.``ml-2``
    static member inline ml3 = PropertyBuilders.mkClass ClassLiterals.``ml-3``
    static member inline ml4 = PropertyBuilders.mkClass ClassLiterals.``ml-4``
    static member inline ml5 = PropertyBuilders.mkClass ClassLiterals.``ml-5``
    static member inline ml6 = PropertyBuilders.mkClass ClassLiterals.``ml-6``
    static member inline mx0 = PropertyBuilders.mkClass ClassLiterals.``mx-0``
    static member inline mx1 = PropertyBuilders.mkClass ClassLiterals.``mx-1``
    static member inline mx2 = PropertyBuilders.mkClass ClassLiterals.``mx-2``
    static member inline mx3 = PropertyBuilders.mkClass ClassLiterals.``mx-3``
    static member inline mx4 = PropertyBuilders.mkClass ClassLiterals.``mx-4``
    static member inline mx5 = PropertyBuilders.mkClass ClassLiterals.``mx-5``
    static member inline mx6 = PropertyBuilders.mkClass ClassLiterals.``mx-6``
    static member inline my0 = PropertyBuilders.mkClass ClassLiterals.``my-0``
    static member inline my1 = PropertyBuilders.mkClass ClassLiterals.``my-1``
    static member inline my2 = PropertyBuilders.mkClass ClassLiterals.``my-2``
    static member inline my3 = PropertyBuilders.mkClass ClassLiterals.``my-3``
    static member inline my4 = PropertyBuilders.mkClass ClassLiterals.``my-4``
    static member inline my5 = PropertyBuilders.mkClass ClassLiterals.``my-5``
    static member inline my6 = PropertyBuilders.mkClass ClassLiterals.``my-6``
    static member inline pt0 = PropertyBuilders.mkClass ClassLiterals.``pt-0``
    static member inline pt1 = PropertyBuilders.mkClass ClassLiterals.``pt-1``
    static member inline pt2 = PropertyBuilders.mkClass ClassLiterals.``pt-2``
    static member inline pt3 = PropertyBuilders.mkClass ClassLiterals.``pt-3``
    static member inline pt4 = PropertyBuilders.mkClass ClassLiterals.``pt-4``
    static member inline pt5 = PropertyBuilders.mkClass ClassLiterals.``pt-5``
    static member inline pt6 = PropertyBuilders.mkClass ClassLiterals.``pt-6``
    static member inline pr0 = PropertyBuilders.mkClass ClassLiterals.``pr-0``
    static member inline pr1 = PropertyBuilders.mkClass ClassLiterals.``pr-1``
    static member inline pr2 = PropertyBuilders.mkClass ClassLiterals.``pr-2``
    static member inline pr3 = PropertyBuilders.mkClass ClassLiterals.``pr-3``
    static member inline pr4 = PropertyBuilders.mkClass ClassLiterals.``pr-4``
    static member inline pr5 = PropertyBuilders.mkClass ClassLiterals.``pr-5``
    static member inline pr6 = PropertyBuilders.mkClass ClassLiterals.``pr-6``
    static member inline pb0 = PropertyBuilders.mkClass ClassLiterals.``pb-0``
    static member inline pb1 = PropertyBuilders.mkClass ClassLiterals.``pb-1``
    static member inline pb2 = PropertyBuilders.mkClass ClassLiterals.``pb-2``
    static member inline pb3 = PropertyBuilders.mkClass ClassLiterals.``pb-3``
    static member inline pb4 = PropertyBuilders.mkClass ClassLiterals.``pb-4``
    static member inline pb5 = PropertyBuilders.mkClass ClassLiterals.``pb-5``
    static member inline pb6 = PropertyBuilders.mkClass ClassLiterals.``pb-6``
    static member inline pl0 = PropertyBuilders.mkClass ClassLiterals.``pl-0``
    static member inline pl1 = PropertyBuilders.mkClass ClassLiterals.``pl-1``
    static member inline pl2 = PropertyBuilders.mkClass ClassLiterals.``pl-2``
    static member inline pl3 = PropertyBuilders.mkClass ClassLiterals.``pl-3``
    static member inline pl4 = PropertyBuilders.mkClass ClassLiterals.``pl-4``
    static member inline pl5 = PropertyBuilders.mkClass ClassLiterals.``pl-5``
    static member inline pl6 = PropertyBuilders.mkClass ClassLiterals.``pl-6``
    static member inline px0 = PropertyBuilders.mkClass ClassLiterals.``px-0``
    static member inline px1 = PropertyBuilders.mkClass ClassLiterals.``px-1``
    static member inline px2 = PropertyBuilders.mkClass ClassLiterals.``px-2``
    static member inline px3 = PropertyBuilders.mkClass ClassLiterals.``px-3``
    static member inline px4 = PropertyBuilders.mkClass ClassLiterals.``px-4``
    static member inline px5 = PropertyBuilders.mkClass ClassLiterals.``px-5``
    static member inline px6 = PropertyBuilders.mkClass ClassLiterals.``px-6``
    static member inline py0 = PropertyBuilders.mkClass ClassLiterals.``py-0``
    static member inline py1 = PropertyBuilders.mkClass ClassLiterals.``py-1``
    static member inline py2 = PropertyBuilders.mkClass ClassLiterals.``py-2``
    static member inline py3 = PropertyBuilders.mkClass ClassLiterals.``py-3``
    static member inline py4 = PropertyBuilders.mkClass ClassLiterals.``py-4``
    static member inline py5 = PropertyBuilders.mkClass ClassLiterals.``py-5``
    static member inline py6 = PropertyBuilders.mkClass ClassLiterals.``py-6``

[<Fable.Core.Erase>]
type text =
    static member inline isFamilySansSerif = PropertyBuilders.mkClass ClassLiterals.``is-family-sans-serif``
    static member inline isFamilyMonospace = PropertyBuilders.mkClass ClassLiterals.``is-family-monospace``
    static member inline isFamilyPrimary = PropertyBuilders.mkClass ClassLiterals.``is-family-primary``
    static member inline isFamilySecondary = PropertyBuilders.mkClass ClassLiterals.``is-family-secondary``
    static member inline isFamilyCode = PropertyBuilders.mkClass ClassLiterals.``is-family-code``

    static member inline isCapitalized = PropertyBuilders.mkClass ClassLiterals.``is-capitalized``
    static member inline isLowercase = PropertyBuilders.mkClass ClassLiterals.``is-lowercase``
    static member inline isUppercase = PropertyBuilders.mkClass ClassLiterals.``is-uppercase``
    static member inline isItalic= PropertyBuilders.mkClass ClassLiterals.``is-italic``

    static member inline hasTextWeightLight = PropertyBuilders.mkClass ClassLiterals.``has-text-weight-light``
    static member inline hasTextWeightNormal = PropertyBuilders.mkClass ClassLiterals.``has-text-weight-normal``
    static member inline hasTextWeightMedium = PropertyBuilders.mkClass ClassLiterals.``has-text-weight-medium``
    static member inline hasTextWeightSemibold = PropertyBuilders.mkClass ClassLiterals.``has-text-weight-semibold``
    static member inline hasTextWeightBold = PropertyBuilders.mkClass ClassLiterals.``has-text-weight-bold``

    static member inline hasTextCentered = PropertyBuilders.mkClass ClassLiterals.``has-text-centered``
    static member inline hasTextJustified = PropertyBuilders.mkClass ClassLiterals.``has-text-justified``
    static member inline hasTextLeft = PropertyBuilders.mkClass ClassLiterals.``has-text-left``
    static member inline hasTextRight = PropertyBuilders.mkClass ClassLiterals.``has-text-right``

    static member inline hasTextCenteredMobile = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-mobile``
    static member inline hasTextJustifiedMobile = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-mobile``
    static member inline hasTextLeftMobile = PropertyBuilders.mkClass ClassLiterals.``has-text-left-mobile``
    static member inline hasTextRightMobile = PropertyBuilders.mkClass ClassLiterals.``has-text-right-mobile``

    static member inline hasTextCenteredTablet = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-tablet``
    static member inline hasTextJustifiedTablet = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-tablet``
    static member inline hasTextLeftTablet = PropertyBuilders.mkClass ClassLiterals.``has-text-left-tablet``
    static member inline hasTextRightTablet = PropertyBuilders.mkClass ClassLiterals.``has-text-right-tablet``

    static member inline hasTextCenteredTabletOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-tablet-only``
    static member inline hasTextJustifiedTabletOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-tablet-only``
    static member inline hasTextLeftTabletOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-left-tablet-only``
    static member inline hasTextRightTabletOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-right-tablet-only``

    static member inline hasTextCenteredTouch = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-touch``
    static member inline hasTextJustifiedTouch = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-touch``
    static member inline hasTextLeftTouch = PropertyBuilders.mkClass ClassLiterals.``has-text-left-touch``
    static member inline hasTextRightTouch = PropertyBuilders.mkClass ClassLiterals.``has-text-right-touch``

    static member inline hasTextCenteredDesktop = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-desktop``
    static member inline hasTextJustifiedDesktop = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-desktop``
    static member inline hasTextLeftDesktop = PropertyBuilders.mkClass ClassLiterals.``has-text-left-desktop``
    static member inline hasTextRightDesktop = PropertyBuilders.mkClass ClassLiterals.``has-text-right-desktop``


    static member inline hasTextCenteredDesktopOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-desktop-only``
    static member inline hasTextJustifiedDesktopOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-desktop-only``
    static member inline hasTextLeftDesktopOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-left-desktop-only``
    static member inline hasTextRightDesktopOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-right-desktop-only``

    static member inline hasTextCenteredWidescreen = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-widescreen``
    static member inline hasTextJustifiedWidescreen = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-widescreen``
    static member inline hasTextLeftWidescreen = PropertyBuilders.mkClass ClassLiterals.``has-text-left-widescreen``
    static member inline hasTextRightWidescreen = PropertyBuilders.mkClass ClassLiterals.``has-text-right-widescreen``

    static member inline hasTextCenteredWidescreenOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-widescreen-only``
    static member inline hasTextJustifiedWidescreenOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-widescreen-only``
    static member inline hasTextLeftWidescreenOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-left-widescreen-only``
    static member inline hasTextRightWidescreenOnly = PropertyBuilders.mkClass ClassLiterals.``has-text-right-widescreen-only``

    static member inline hasTextCenteredFullHd = PropertyBuilders.mkClass ClassLiterals.``has-text-centered-fullhd``
    static member inline hasTextJustifiedFullHd = PropertyBuilders.mkClass ClassLiterals.``has-text-justified-fullhd``
    static member inline hasTextLeftFullHd = PropertyBuilders.mkClass ClassLiterals.``has-text-left-fullhd``
    static member inline hasTextRightFullHd = PropertyBuilders.mkClass ClassLiterals.``has-text-right-fullhd``

[<Fable.Core.Erase>]
type color =
    static member inline isWhite = PropertyBuilders.mkClass ClassLiterals.``is-white``
    static member inline isBlack = PropertyBuilders.mkClass ClassLiterals.``is-black``
    static member inline isLight = PropertyBuilders.mkClass ClassLiterals.``is-light``
    static member inline isDark = PropertyBuilders.mkClass ClassLiterals.``is-dark``
    static member inline isPrimary = PropertyBuilders.mkClass ClassLiterals.``is-primary``
    static member inline isLink = PropertyBuilders.mkClass ClassLiterals.``is-link``
    static member inline isInfo = PropertyBuilders.mkClass ClassLiterals.``is-info``
    static member inline isSuccess = PropertyBuilders.mkClass ClassLiterals.``is-success``
    static member inline isWarning = PropertyBuilders.mkClass ClassLiterals.``is-warning``
    static member inline isDanger = PropertyBuilders.mkClass ClassLiterals.``is-danger``

    static member inline hasTextWhite = PropertyBuilders.mkClass ClassLiterals.``has-text-white``
    static member inline hasTextBlack = PropertyBuilders.mkClass ClassLiterals.``has-text-black``
    static member inline hasTextLight = PropertyBuilders.mkClass ClassLiterals.``has-text-light``
    static member inline hasTextDark = PropertyBuilders.mkClass ClassLiterals.``has-text-dark``
    static member inline hasTextPrimary = PropertyBuilders.mkClass ClassLiterals.``has-text-primary``
    static member inline hasTextInfo = PropertyBuilders.mkClass ClassLiterals.``has-text-info``
    static member inline hasTextLink = PropertyBuilders.mkClass ClassLiterals.``has-text-link``
    static member inline hasTextSuccess = PropertyBuilders.mkClass ClassLiterals.``has-text-success``
    static member inline hasTextWarning = PropertyBuilders.mkClass ClassLiterals.``has-text-warning``
    static member inline hasTextDanger = PropertyBuilders.mkClass ClassLiterals.``has-text-danger``
    static member inline hasTextBlackBis = PropertyBuilders.mkClass ClassLiterals.``has-text-black-bis``
    static member inline hasTextBlackTer = PropertyBuilders.mkClass ClassLiterals.``has-text-black-ter``
    static member inline hasTextGreyDarker = PropertyBuilders.mkClass ClassLiterals.``has-text-grey-darker``
    static member inline hasTextGreyDark = PropertyBuilders.mkClass ClassLiterals.``has-text-grey-dark``
    static member inline hasTextGrey = PropertyBuilders.mkClass ClassLiterals.``has-text-grey``
    static member inline hasTextGreyLight = PropertyBuilders.mkClass ClassLiterals.``has-text-grey-light``
    static member inline hasTextGreyLighter = PropertyBuilders.mkClass ClassLiterals.``has-text-grey-lighter``
    static member inline hasTextWhiteTer = PropertyBuilders.mkClass ClassLiterals.``has-text-white-ter``
    static member inline hasTextWhiteBis = PropertyBuilders.mkClass ClassLiterals.``has-text-white-bis``

    static member inline hasBackgroundWhite = PropertyBuilders.mkClass ClassLiterals.``has-background-white``
    static member inline hasBackgroundBlack = PropertyBuilders.mkClass ClassLiterals.``has-background-black``
    static member inline hasBackgroundLight = PropertyBuilders.mkClass ClassLiterals.``has-background-light``
    static member inline hasBackgroundDark = PropertyBuilders.mkClass ClassLiterals.``has-background-dark``
    static member inline hasBackgroundPrimary = PropertyBuilders.mkClass ClassLiterals.``has-background-primary``
    static member inline hasBackgroundInfo = PropertyBuilders.mkClass ClassLiterals.``has-background-info``
    static member inline hasBackgroundLink = PropertyBuilders.mkClass ClassLiterals.``has-background-link``
    static member inline hasBackgroundSuccess = PropertyBuilders.mkClass ClassLiterals.``has-background-success``
    static member inline hasBackgroundWarning = PropertyBuilders.mkClass ClassLiterals.``has-background-warning``
    static member inline hasBackgroundDanger = PropertyBuilders.mkClass ClassLiterals.``has-background-danger``
    static member inline hasBackgroundBlackBis = PropertyBuilders.mkClass ClassLiterals.``has-background-black-bis``
    static member inline hasBackgroundBlackTer = PropertyBuilders.mkClass ClassLiterals.``has-background-black-ter``
    static member inline hasBackgroundGreyDarker = PropertyBuilders.mkClass ClassLiterals.``has-background-grey-darker``
    static member inline hasBackgroundGreyDark = PropertyBuilders.mkClass ClassLiterals.``has-background-grey-dark``
    static member inline hasBackgroundGrey = PropertyBuilders.mkClass ClassLiterals.``has-background-grey``
    static member inline hasBackgroundGreyLight = PropertyBuilders.mkClass ClassLiterals.``has-background-grey-light``
    static member inline hasBackgroundGreyLighter = PropertyBuilders.mkClass ClassLiterals.``has-background-grey-lighter``
    static member inline hasBackgroundWhiteTer = PropertyBuilders.mkClass ClassLiterals.``has-background-white-ter``
    static member inline hasBackgroundWhiteBis = PropertyBuilders.mkClass ClassLiterals.``has-background-white-bis``

[<Fable.Core.Erase>]
type image =
    static member inline is16x16 = PropertyBuilders.mkClass ClassLiterals.``is-16x16``
    static member inline is24x24 = PropertyBuilders.mkClass ClassLiterals.``is-24x24``
    static member inline is32x32 = PropertyBuilders.mkClass ClassLiterals.``is-32x32``
    static member inline is48x48 = PropertyBuilders.mkClass ClassLiterals.``is-48x48``
    static member inline is64x64 = PropertyBuilders.mkClass ClassLiterals.``is-64x64``
    static member inline is96x96 = PropertyBuilders.mkClass ClassLiterals.``is-96x96``
    static member inline is128x128 = PropertyBuilders.mkClass ClassLiterals.``is-128x128``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSquare = PropertyBuilders.mkClass ClassLiterals.``is-square``
    static member inline is1by1 = PropertyBuilders.mkClass ClassLiterals.``is-1by1``
    static member inline is5by4 = PropertyBuilders.mkClass ClassLiterals.``is-5by4``
    static member inline is4by3 = PropertyBuilders.mkClass ClassLiterals.``is-4by3``
    static member inline is3by2 = PropertyBuilders.mkClass ClassLiterals.``is-3by2``
    static member inline is5by3 = PropertyBuilders.mkClass ClassLiterals.``is-5by3``
    static member inline is16by9 = PropertyBuilders.mkClass ClassLiterals.``is-16by9``
    static member inline is2by1 = PropertyBuilders.mkClass ClassLiterals.``is-2by1``
    static member inline is3by1 = PropertyBuilders.mkClass ClassLiterals.``is-3by1``
    static member inline is4by5 = PropertyBuilders.mkClass ClassLiterals.``is-4by5``
    static member inline is3by4 = PropertyBuilders.mkClass ClassLiterals.``is-3by4``
    static member inline is2by3 = PropertyBuilders.mkClass ClassLiterals.``is-2by3``
    static member inline is3by5 = PropertyBuilders.mkClass ClassLiterals.``is-3by5``
    static member inline is9by16 = PropertyBuilders.mkClass ClassLiterals.``is-9by16``
    static member inline is1by2 = PropertyBuilders.mkClass ClassLiterals.``is-1by2``
    static member inline is1by3 = PropertyBuilders.mkClass ClassLiterals.``is-1by3``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline hasRatio = PropertyBuilders.mkClass ClassLiterals.``has-ratio``

[<Fable.Core.Erase>]
type progress =
    static member inline value v = PropertyBuilders.mkValue v
    static member inline max v = PropertyBuilders.mkMax v
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type table =
    static member inline isBordered = PropertyBuilders.mkClass ClassLiterals.``is-bordered``
    static member inline isStriped = PropertyBuilders.mkClass ClassLiterals.``is-striped``
    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``
    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``

[<Fable.Core.Erase>]
type tr =
    static member inline isSelected = PropertyBuilders.mkClass ClassLiterals.``is-selected``

[<Fable.Core.Erase>]
type tag =
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isDelete = PropertyBuilders.mkClass ClassLiterals.``is-delete``

[<Fable.Core.Erase>]
type tags =
    static member inline areSmall = PropertyBuilders.mkClass ClassLiterals.``are-small``
    static member inline areMedium = PropertyBuilders.mkClass ClassLiterals.``are-medium``
    static member inline areLarge = PropertyBuilders.mkClass ClassLiterals.``are-large``
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``

[<Fable.Core.Erase>]
type title =
    static member inline isSpaced = PropertyBuilders.mkClass ClassLiterals.``is-spaced``
    static member inline is1 = PropertyBuilders.mkClass ClassLiterals.``is-1``
    static member inline is2 = PropertyBuilders.mkClass ClassLiterals.``is-2``
    static member inline is3 = PropertyBuilders.mkClass ClassLiterals.``is-3``
    static member inline is4 = PropertyBuilders.mkClass ClassLiterals.``is-4``
    static member inline is5 = PropertyBuilders.mkClass ClassLiterals.``is-5``
    static member inline is6 = PropertyBuilders.mkClass ClassLiterals.``is-6``

[<Fable.Core.Erase>]
type tabs =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``
    static member inline isToggle = PropertyBuilders.mkClass ClassLiterals.``is-toggle``
    static member inline isToggleRounded = PropertyBuilders.mkClass ClassLiterals.``is-toggle-rounded``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``

[<Fable.Core.Erase>]
type tab =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type breadcrumb =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline hasArrowSeparator = PropertyBuilders.mkClass ClassLiterals.``has-arrow-separator``
    static member inline hasBulletSeparator = PropertyBuilders.mkClass ClassLiterals.``has-bullet-separator``
    static member inline hasDotSeparator = PropertyBuilders.mkClass ClassLiterals.``has-dot-separator``
    static member inline hasSucceedsSeparator = PropertyBuilders.mkClass ClassLiterals.``has-succeeds-separator``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type cardHeaderTitle =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``

[<Fable.Core.Erase>]
type dropdown =
    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isUp = PropertyBuilders.mkClass ClassLiterals.``is-up``

[<Fable.Core.Erase>]
type modal =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type modalClose =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type navbar =
    static member inline isTransparent = PropertyBuilders.mkClass ClassLiterals.``is-transparent``
    static member inline hasShadow = PropertyBuilders.mkClass ClassLiterals.``has-shadow``
    static member inline isFixedTop = PropertyBuilders.mkClass ClassLiterals.``is-fixed-top``
    static member inline isFixedBottom = PropertyBuilders.mkClass ClassLiterals.``is-fixed-bottom``

[<Fable.Core.Erase>]
type navbarMenu =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    [<Obsolete("This prop is deprecated. Use `navbar.isFixedTop` instead.")>]
    static member inline isFixedTop = PropertyBuilders.mkClass ClassLiterals.``is-fixed-top``
    [<Obsolete("This prop is deprecated. Use `navbar.isFixedBottom` instead.")>]
    static member inline isFixedBottom = PropertyBuilders.mkClass ClassLiterals.``is-fixed-bottom``

[<Fable.Core.Erase>]
type navbarBurger =
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type navbarDropdown =
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``

[<Fable.Core.Erase>]
type navbarLink =
    static member inline isArrowless = PropertyBuilders.mkClass ClassLiterals.``is-arrowless``

[<Fable.Core.Erase>]
type navbarItem =
    static member inline isExpanded = PropertyBuilders.mkClass ClassLiterals.``is-expanded``
    static member inline isTab = PropertyBuilders.mkClass ClassLiterals.``is-tab``
    static member inline hasDropdown = PropertyBuilders.mkClass ClassLiterals.``has-dropdown``
    static member inline hasDropdownUp = PropertyBuilders.mkClass ClassLiterals.``has-dropdown-up``
    static member inline isHoverable = PropertyBuilders.mkClass ClassLiterals.``is-hoverable``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type pagination =
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type paginationLink =
    static member inline isCurrent = PropertyBuilders.mkClass ClassLiterals.``is-current``

[<Fable.Core.Erase>]
type file =
    static member inline hasName = PropertyBuilders.mkClass ClassLiterals.``has-name``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isBoxed = PropertyBuilders.mkClass ClassLiterals.``is-boxed``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type input =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``

[<Fable.Core.Erase>]
type button =
    static member inline isStatic = PropertyBuilders.mkClass ClassLiterals.``is-static``
    static member inline isOutlined = PropertyBuilders.mkClass ClassLiterals.``is-outlined``
    static member inline isLoading = PropertyBuilders.mkClass ClassLiterals.``is-loading``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isInverted = PropertyBuilders.mkClass ClassLiterals.``is-inverted``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``
    static member inline isSelected = PropertyBuilders.mkClass ClassLiterals.``is-selected``
    static member inline isText = PropertyBuilders.mkClass ClassLiterals.``is-text``

[<Fable.Core.Erase>]
type buttons =
    static member inline areSmall = PropertyBuilders.mkClass ClassLiterals.``are-small``
    static member inline areMedium = PropertyBuilders.mkClass ClassLiterals.``are-medium``
    static member inline areLarge = PropertyBuilders.mkClass ClassLiterals.``are-large``
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``

[<Fable.Core.Erase>]
type fieldLabel =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type textarea =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline hasFixedSize = PropertyBuilders.mkClass ClassLiterals.``has-fixed-size``

[<Fable.Core.Erase>]
type field =
    static member inline hasAddons = PropertyBuilders.mkClass ClassLiterals.``has-addons``
    static member inline hasAddonsRight = PropertyBuilders.mkClass ClassLiterals.``has-addons-right``
    static member inline hasAddonsCentered = PropertyBuilders.mkClass ClassLiterals.``has-addons-centered``
    static member inline isGrouped = PropertyBuilders.mkClass ClassLiterals.``is-grouped``
    static member inline isGroupedRight = PropertyBuilders.mkClass ClassLiterals.``is-grouped-right``
    static member inline isGroupedCentered = PropertyBuilders.mkClass ClassLiterals.``is-grouped-centered``
    static member inline isGroupedMultiline = PropertyBuilders.mkClass ClassLiterals.``is-grouped-multiline``
    static member inline isHorizontal = PropertyBuilders.mkClass ClassLiterals.``is-horizontal``
    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``

[<Fable.Core.Erase>]
type icon =
    static member inline isLeft = PropertyBuilders.mkClass ClassLiterals.``is-left``
    static member inline isRight = PropertyBuilders.mkClass ClassLiterals.``is-right``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type select =
    static member inline isFullWidth = PropertyBuilders.mkClass ClassLiterals.``is-fullwidth``
    static member inline isMultiple = PropertyBuilders.mkClass ClassLiterals.``is-multiple``
    static member inline isRounded = PropertyBuilders.mkClass ClassLiterals.``is-rounded``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isNormal = PropertyBuilders.mkClass ClassLiterals.``is-normal``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isHovered = PropertyBuilders.mkClass ClassLiterals.``is-hovered``
    static member inline isFocused = PropertyBuilders.mkClass ClassLiterals.``is-focused``
    static member inline isActive = PropertyBuilders.mkClass ClassLiterals.``is-active``

[<Fable.Core.Erase>]
type control =
    static member inline hasIconsLeft = PropertyBuilders.mkClass ClassLiterals.``has-icons-left``
    static member inline hasIconsRight = PropertyBuilders.mkClass ClassLiterals.``has-icons-right``
    static member inline isExpanded = PropertyBuilders.mkClass ClassLiterals.``is-expanded``
    static member inline isLoading = PropertyBuilders.mkClass ClassLiterals.``is-loading``
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type ol =
    static member inline isLowerAlpha = PropertyBuilders.mkClass ClassLiterals.``is-lower-alpha``
    static member inline isLowerRoman = PropertyBuilders.mkClass ClassLiterals.``is-lower-roman``
    static member inline isUpperAlpha = PropertyBuilders.mkClass ClassLiterals.``is-upper-alpha``
    static member inline isUpperRoman = PropertyBuilders.mkClass ClassLiterals.``is-upper-roman``

[<Fable.Core.Erase>]
type content =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type delete =
    static member inline isSmall = PropertyBuilders.mkClass ClassLiterals.``is-small``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type container =
    static member inline isFluid = PropertyBuilders.mkClass ClassLiterals.``is-fluid``
    static member inline isWidescreen = PropertyBuilders.mkClass ClassLiterals.``is-widescreen``
    static member inline isFullHd = PropertyBuilders.mkClass ClassLiterals.``is-fullhd``

[<Fable.Core.Erase>]
type level =
    static member inline isMobile = PropertyBuilders.mkClass ClassLiterals.``is-mobile``

[<RequireQualifiedAccess>]
type section =
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``

[<Fable.Core.Erase>]
type hero =
    static member inline isBold = PropertyBuilders.mkClass ClassLiterals.``is-bold``
    static member inline isMedium = PropertyBuilders.mkClass ClassLiterals.``is-medium``
    static member inline isLarge = PropertyBuilders.mkClass ClassLiterals.``is-large``
    static member inline isFullHeight = PropertyBuilders.mkClass ClassLiterals.``is-fullheight``
    static member inline isFullHeightWithNavbar = PropertyBuilders.mkClass ClassLiterals.``is-fullheight-with-navbar``

[<Fable.Core.Erase>]
type tile =
    static member inline isAncestor = PropertyBuilders.mkClass ClassLiterals.``is-ancestor``
    static member inline isParent = PropertyBuilders.mkClass ClassLiterals.``is-parent``
    static member inline isChild = PropertyBuilders.mkClass ClassLiterals.``is-child``
    static member inline isVertical = PropertyBuilders.mkClass ClassLiterals.``is-vertical``
    static member inline is1 = PropertyBuilders.mkClass ClassLiterals.``is-1``
    static member inline is2 = PropertyBuilders.mkClass ClassLiterals.``is-2``
    static member inline is3 = PropertyBuilders.mkClass ClassLiterals.``is-3``
    static member inline is4 = PropertyBuilders.mkClass ClassLiterals.``is-4``
    static member inline is5 = PropertyBuilders.mkClass ClassLiterals.``is-5``
    static member inline is6 = PropertyBuilders.mkClass ClassLiterals.``is-6``
    static member inline is7 = PropertyBuilders.mkClass ClassLiterals.``is-7``
    static member inline is8 = PropertyBuilders.mkClass ClassLiterals.``is-8``
    static member inline is9 = PropertyBuilders.mkClass ClassLiterals.``is-9``
    static member inline is10 = PropertyBuilders.mkClass ClassLiterals.``is-10``
    static member inline is11 = PropertyBuilders.mkClass ClassLiterals.``is-11``
    static member inline is12 = PropertyBuilders.mkClass ClassLiterals.``is-12``

[<Fable.Core.Erase>]
type columns =
    static member inline isMobile = PropertyBuilders.mkClass ClassLiterals.``is-mobile``
    static member inline isDesktop = PropertyBuilders.mkClass ClassLiterals.``is-desktop``
    static member inline isGapless = PropertyBuilders.mkClass ClassLiterals.``is-gapless``
    static member inline isMultiline = PropertyBuilders.mkClass ClassLiterals.``is-multiline``
    static member inline isVariable = PropertyBuilders.mkClass ClassLiterals.``is-variable``
    static member inline isCentered = PropertyBuilders.mkClass ClassLiterals.``is-centered``
    static member inline isVCentered = PropertyBuilders.mkClass ClassLiterals.``is-vcentered``

[<Fable.Core.Erase>]
type column =
    static member inline is1 = PropertyBuilders.mkClass ClassLiterals.``is-1``
    static member inline is2 = PropertyBuilders.mkClass ClassLiterals.``is-2``
    static member inline is3 = PropertyBuilders.mkClass ClassLiterals.``is-3``
    static member inline is4 = PropertyBuilders.mkClass ClassLiterals.``is-4``
    static member inline is5 = PropertyBuilders.mkClass ClassLiterals.``is-5``
    static member inline is6 = PropertyBuilders.mkClass ClassLiterals.``is-6``
    static member inline is7 = PropertyBuilders.mkClass ClassLiterals.``is-7``
    static member inline is8 = PropertyBuilders.mkClass ClassLiterals.``is-8``
    static member inline is9 = PropertyBuilders.mkClass ClassLiterals.``is-9``
    static member inline is10 = PropertyBuilders.mkClass ClassLiterals.``is-10``
    static member inline is11 = PropertyBuilders.mkClass ClassLiterals.``is-11``
    static member inline is12 = PropertyBuilders.mkClass ClassLiterals.``is-12``

    static member inline isThreeQuarters = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters``
    static member inline isTwoThirds = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds``
    static member inline isHalf = PropertyBuilders.mkClass ClassLiterals.``is-half``
    static member inline isOneThird = PropertyBuilders.mkClass ClassLiterals.``is-one-third``
    static member inline isOneQuarter = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter``
    static member inline isFull = PropertyBuilders.mkClass ClassLiterals.``is-full``
    static member inline isFourFifths = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths``
    static member inline isThreeFifths = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths``
    static member inline isTwoFifths = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths``
    static member inline isOneFifth = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth``
    static member inline isNarrow = PropertyBuilders.mkClass ClassLiterals.``is-narrow``
    static member inline isNarrowMobile = PropertyBuilders.mkClass ClassLiterals.``is-narrow-mobile``
    static member inline isNarrowTablet = PropertyBuilders.mkClass ClassLiterals.``is-narrow-tablet``
    static member inline isNarrowTouch = PropertyBuilders.mkClass ClassLiterals.``is-narrow-touch``
    static member inline isNarrowDesktop = PropertyBuilders.mkClass ClassLiterals.``is-narrow-desktop``
    static member inline isNarrowWidescreen = PropertyBuilders.mkClass ClassLiterals.``is-narrow-widescreen``
    static member inline isNarrowFullHd = PropertyBuilders.mkClass ClassLiterals.``is-narrow-fullhd``

    static member inline isOffset1 = PropertyBuilders.mkClass ClassLiterals.``is-offset-1``
    static member inline isOffset2 = PropertyBuilders.mkClass ClassLiterals.``is-offset-2``
    static member inline isOffset3 = PropertyBuilders.mkClass ClassLiterals.``is-offset-3``
    static member inline isOffset4 = PropertyBuilders.mkClass ClassLiterals.``is-offset-4``
    static member inline isOffset5 = PropertyBuilders.mkClass ClassLiterals.``is-offset-5``
    static member inline isOffset6 = PropertyBuilders.mkClass ClassLiterals.``is-offset-6``
    static member inline isOffset7 = PropertyBuilders.mkClass ClassLiterals.``is-offset-7``
    static member inline isOffset8 = PropertyBuilders.mkClass ClassLiterals.``is-offset-8``
    static member inline isOffset9 = PropertyBuilders.mkClass ClassLiterals.``is-offset-9``
    static member inline isOffset10 = PropertyBuilders.mkClass ClassLiterals.``is-offset-10``
    static member inline isOffset11 = PropertyBuilders.mkClass ClassLiterals.``is-offset-11``
    static member inline isOffset12 = PropertyBuilders.mkClass ClassLiterals.``is-offset-12``
    static member inline isOffsetThreeQuarters = PropertyBuilders.mkClass ClassLiterals.``is-offset-three-quarters``
    static member inline isOffsetTwoThirds = PropertyBuilders.mkClass ClassLiterals.``is-offset-two-thirds``
    static member inline isOffsetHalf = PropertyBuilders.mkClass ClassLiterals.``is-offset-half``
    static member inline isOffsetOneThird = PropertyBuilders.mkClass ClassLiterals.``is-offset-one-third``
    static member inline isOffsetOneQuarter = PropertyBuilders.mkClass ClassLiterals.``is-offset-one-quarter``
    static member inline isOffsetFull = PropertyBuilders.mkClass ClassLiterals.``is-offset-full``
    static member inline isOffsetFourFifths = PropertyBuilders.mkClass ClassLiterals.``is-offset-four-fifths``
    static member inline isOffsetThreeFifths = PropertyBuilders.mkClass ClassLiterals.``is-offset-three-fifths``
    static member inline isOffsetTwoFifths = PropertyBuilders.mkClass ClassLiterals.``is-offset-two-fifths``
    static member inline isOffsetOneFifth = PropertyBuilders.mkClass ClassLiterals.``is-offset-one-fifth``

    static member inline isThreeQuartersMobile = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-mobile``
    static member inline isTwoThirdsMobile = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-mobile``
    static member inline isHalfMobile = PropertyBuilders.mkClass ClassLiterals.``is-half-mobile``
    static member inline isOneThirdMobile = PropertyBuilders.mkClass ClassLiterals.``is-one-third-mobile``
    static member inline isOneQuarterMobile = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-mobile``
    static member inline isFullMobile = PropertyBuilders.mkClass ClassLiterals.``is-full-mobile``
    static member inline isFourFifthsMobile = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-mobile``
    static member inline isThreeFifthsMobile = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-mobile``
    static member inline isTwoFifthsMobile = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-mobile``
    static member inline isOneFifthMobile = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-mobile``
    static member inline isThreeQuartersTablet = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-tablet``
    static member inline isTwoThirdsTablet = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-tablet``
    static member inline isHalfTablet = PropertyBuilders.mkClass ClassLiterals.``is-half-tablet``
    static member inline isOneThirdTablet = PropertyBuilders.mkClass ClassLiterals.``is-one-third-tablet``
    static member inline isOneQuarterTablet = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-tablet``
    static member inline isFullTablet = PropertyBuilders.mkClass ClassLiterals.``is-full-tablet``
    static member inline isFourFifthsTablet = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-tablet``
    static member inline isThreeFifthsTablet = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-tablet``
    static member inline isTwoFifthsTablet = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-tablet``
    static member inline isOneFifthTablet = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-tablet``
    static member inline isThreeQuartersDesktop = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-desktop``
    static member inline isTwoThirdsDesktop = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-desktop``
    static member inline isHalfDesktop = PropertyBuilders.mkClass ClassLiterals.``is-half-desktop``
    static member inline isOneThirdDesktop = PropertyBuilders.mkClass ClassLiterals.``is-one-third-desktop``
    static member inline isOneQuarterDesktop = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-desktop``
    static member inline isFullDesktop = PropertyBuilders.mkClass ClassLiterals.``is-full-desktop``
    static member inline isFourFifthsDesktop = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-desktop``
    static member inline isThreeFifthsDesktop = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-desktop``
    static member inline isTwoFifthsDesktop = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-desktop``
    static member inline isOneFifthDesktop = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-desktop``
    static member inline isThreeQuartersWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-widescreen``
    static member inline isTwoThirdsWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-widescreen``
    static member inline isHalfWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-half-widescreen``
    static member inline isOneThirdWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-one-third-widescreen``
    static member inline isOneQuarterWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-widescreen``
    static member inline isFullWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-full-widescreen``
    static member inline isFourFifthsWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-widescreen``
    static member inline isThreeFifthsWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-widescreen``
    static member inline isTwoFifthsWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-widescreen``
    static member inline isOneFifthWideScreen = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-widescreen``
    static member inline isThreeQuartersFullHd = PropertyBuilders.mkClass ClassLiterals.``is-three-quarters-fullhd``
    static member inline isTwoThirdsFullHd = PropertyBuilders.mkClass ClassLiterals.``is-two-thirds-fullhd``
    static member inline isHalfFullHd = PropertyBuilders.mkClass ClassLiterals.``is-half-fullhd``
    static member inline isOneThirdFullHd = PropertyBuilders.mkClass ClassLiterals.``is-one-third-fullhd``
    static member inline isOneQuarterFullHd = PropertyBuilders.mkClass ClassLiterals.``is-one-quarter-fullhd``
    static member inline isFullFullHd = PropertyBuilders.mkClass ClassLiterals.``is-full-fullhd``
    static member inline isFourFifthsFullHd = PropertyBuilders.mkClass ClassLiterals.``is-four-fifths-fullhd``
    static member inline isThreeFifthsFullHd = PropertyBuilders.mkClass ClassLiterals.``is-three-fifths-fullhd``
    static member inline isTwoFifthsFullHd = PropertyBuilders.mkClass ClassLiterals.``is-two-fifths-fullhd``
    static member inline isOneFifthFullHd = PropertyBuilders.mkClass ClassLiterals.``is-one-fifth-fullhd``
